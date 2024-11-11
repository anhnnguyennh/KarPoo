using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodCollision : MonoBehaviour
{
    public static int foodEatenCount = 0;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            foodEatenCount++;
            Destroy(gameObject);
            collision.gameObject.GetComponent<Player>().Heal(2);
        }
    }
}
