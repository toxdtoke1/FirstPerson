using UnityEngine;

public class RecibeDamage: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public int health = 100;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("bala"))
        {
            Debug.Log("Recibio daño de bala");
            Destroy(collision.gameObject);
            health -= 10;
            Debug.Log("Vida Actual: " + health);

            if (health <=0)
            {
                Debug.Log("Enemigo muerto");
                Destroy(gameObject);
            }
        }
    }
}
