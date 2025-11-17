using System.Collections;
using UnityEngine;

public class shootHandler : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private Transform firePoint;
    [SerializeField] private float shotSpeed = 20f;
    [SerializeField] private float shootCooldown = 1f;
    private bool canShoot = true;

    public void ShootTurret()
    {
        if (canShoot)
        {
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        bulletInstance.GetComponent<Rigidbody2D>().linearVelocity = firePoint.up * shotSpeed;
        StartCoroutine(ShootCooldown(shootCooldown));
        }
        
    }

    IEnumerator ShootCooldown(float cooldownTime)
    {
        canShoot = false;
        yield return new WaitForSeconds(cooldownTime);
        canShoot = true;
    }
}
