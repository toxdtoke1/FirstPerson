using UnityEngine;

public class playerCollision : MonoBehaviour
{
    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.gameObject.CompareTag("Enemy"))
        {
            if (GameController.Instance != null)
            {
                GameController.Instance.JugadorMuerto();
            }
        }
    }
}