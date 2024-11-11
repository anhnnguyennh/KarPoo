using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopMovement : MonoBehaviour
{
    //private Transform player;
    public float speed = 8f;

    private Vector3 oppositeDirection;

    private void Start()
    {
        //player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        //Vector3 directionToPlayer = (player.position - transform.position).normalized;
        //oppositeDirection = -directionToPlayer;

        Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector3 directionToPlayer = (mousePos - transform.position).normalized;
        oppositeDirection = -directionToPlayer;
    }

    void Update()
    {
        transform.position += oppositeDirection * speed * Time.deltaTime;
    }
}
