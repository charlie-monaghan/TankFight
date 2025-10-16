using UnityEngine;

public class turretRotation : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 100f;

    public void RotateTurret(float direction)
    {
        transform.Rotate(0, 0, direction * rotationSpeed * Time.deltaTime);
    }
}
