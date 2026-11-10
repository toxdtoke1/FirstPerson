using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public static GameController Instance;

    public TextMeshProUGUI textoEnemigosRestantes;

    [Header("Paneles UI")]
    public GameObject panelVictoria;
    public GameObject panelDerrota; 

    private int enemigosTotales = 0;

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        if (panelVictoria != null) panelVictoria.SetActive(false);
        if (panelDerrota != null) panelDerrota.SetActive(false);
        Time.timeScale = 1f;
    }

    public void RegistrarEnemigo()
    {
        enemigosTotales++;
        ActualizarTextoUI();
    }

    public void EnemigoDerrotado()
    {
        enemigosTotales--;
        ActualizarTextoUI();

        if (enemigosTotales <= 0)
        {
            CondicionVictoria();
        }
    }

   
    public void JugadorMuerto()
    {

        
        if (textoEnemigosRestantes != null)
        {
            textoEnemigosRestantes.gameObject.SetActive(false);
        }

        
        if (panelDerrota != null)
        {
            panelDerrota.SetActive(true);
        }

       
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }

    void ActualizarTextoUI()
    {
        if (textoEnemigosRestantes != null)
        {
            textoEnemigosRestantes.text = "Enemigos restantes: " + enemigosTotales;
        }
    }

    void CondicionVictoria()
    {
        Debug.Log("¡VICTORIA! Todos los enemigos han sido eliminados.");

        if (textoEnemigosRestantes != null)
        {
            textoEnemigosRestantes.gameObject.SetActive(false);
        }

        if (panelVictoria != null)
        {
            panelVictoria.SetActive(true);
        }

        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        Time.timeScale = 0f;
    }

    public void ReiniciarJuego()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void SalirJuego()
    {
        Debug.Log("Saliendo del juego...");
        Application.Quit();

#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#endif
    }
}