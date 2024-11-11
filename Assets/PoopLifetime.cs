using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopLifetime : MonoBehaviour
{
    public float lifetime = 5f;
    private GameManager gameManager;

    void Start()
    {
        Destroy(gameObject, lifetime);

        gameManager = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(gameObject); // Destroy the poop
            Destroy(other.gameObject); // Destroy the enemy

            gameManager.AddScore();
        }
    }

}
