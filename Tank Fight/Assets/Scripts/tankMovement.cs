using UnityEngine;

public class tankMovement : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    private Vector2 movementVector;
    [SerializeField] private float maxSpeed = 10f;
    [SerializeField] private float rotationSpeed = 100f;

    private void Awake()
    {
        if (rb == null)
        {
            rb = GetComponent<Rigidbody2D>();
        }
    }

    public void HandleMovement(Vector2 movementVector)
    {
        rb.linearVelocity = (Vector2)transform.up * movementVector.y * maxSpeed * Time.fixedDeltaTime;
        rb.MoveRotation(transform.rotation * Quaternion.Euler(0, 0, -movementVector.x * rotationSpeed * Time.fixedDeltaTime));
    }
}
