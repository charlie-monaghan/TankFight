using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class KeyBindings
{
    [Header("Movement (WASD format)")]
    public KeyCode forward;
    public KeyCode backward;
    public KeyCode rotateLeft;
    public KeyCode rotateRight;

    [Header("Turret Rotation")]
    public KeyCode turretLeft;
    public KeyCode turretRight;

    [Header("Fire")]
    public KeyCode fire;
}

public class playerInput : MonoBehaviour
{
    public UnityEvent<Vector2> OnMoveBody = new UnityEvent<Vector2>();
    public UnityEvent<float> OnMoveTurret = new UnityEvent<float>();
    public UnityEvent OnFire = new UnityEvent();

    [SerializeField] private KeyBindings keyBindings;

    private void GetBodyMovement()
    {
        Vector2 movementVector = Vector2.zero;

        if (Input.GetKey(keyBindings.forward))
        {
            movementVector.y += 1;
        }
        if (Input.GetKey(keyBindings.backward))
        {
            movementVector.y -= 1;
        }
        if (Input.GetKey(keyBindings.rotateLeft))
        {
            movementVector.x -= 1;
        }
        if (Input.GetKey(keyBindings.rotateRight))
        {
            movementVector.x += 1;
        }

        OnMoveBody?.Invoke(movementVector.normalized);
    }

    private void GetTurretMovement()
    {
        float direction = 0f;

        if (Input.GetKey(keyBindings.turretLeft))
        {
            direction = 1f;
        }
        if (Input.GetKey(keyBindings.turretRight))
        {
            direction = -1f;
        }

        if(direction != 0)
        {
            OnMoveTurret?.Invoke(direction);
            
        }
    }

    private void GetFire()
    {
        if(Input.GetKeyDown(keyBindings.fire))
        {
            OnFire?.Invoke();    
        }
    }

    void Update()
    {
        GetBodyMovement();

        GetTurretMovement();

        GetFire();
    }
}
