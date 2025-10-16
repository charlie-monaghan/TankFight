using UnityEngine;

public class bulletDespawner : MonoBehaviour
{
    [SerializeField] private float lifetime = 3f;

    private void Start()
    {
        Destroy(gameObject, lifetime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Bullet"))
        {
            return;
        }
        Destroy(collision.gameObject);
        Destroy(gameObject);
    }

}
