using UnityEngine;

public class shootHandler : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float shotSpeed = 20f;

    public void ShootTurret()
    {
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletInstance.GetComponent<Rigidbody2D>().linearVelocity = firePoint.up * shotSpeed;
    }
}
