using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecibeDamage: MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public TextMeshProUGUI vidaTexto;

    public int health = 100;

    public Image BarraVida;

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
            
            health -= 25;
            vidaTexto.text = health.ToString();
            BarraVida.fillAmount = health / 100f;
            Debug.Log(gameObject.name + " Vida Actual: " + health);



            if (health <=0)
            {
                Debug.Log("Enemigo muerto");
                Destroy(gameObject);

            }
        }
    }
}
