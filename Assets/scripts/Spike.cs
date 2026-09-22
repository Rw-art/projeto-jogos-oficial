using UnityEngine;

public class Spike : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D Collision){
        if (Collision.gameObject.CompareTag("Player"))

    {
        Collision.gameObject.SendMessage("Die");
    }
    }
}