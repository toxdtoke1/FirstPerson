using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class RecibeDamage : MonoBehaviour
{
    public TextMeshProUGUI vidaTexto;
    public int health = 100;
    public Image BarraVida;

    void Start()
    {
        
        GameController.Instance.RegistrarEnemigo();
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

            if (health <= 0)
            {
                Debug.Log("Enemigo muerto");
                GameController.Instance.EnemigoDerrotado();
                Destroy(gameObject);
            }
        }

        
        if (collision.gameObject.CompareTag("Player"))
        {
            Debug.Log("El enemigo tocó al jugador");
            GameController.Instance.JugadorMuerto();
        }
    }
}