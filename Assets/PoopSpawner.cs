using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoopSpawner : MonoBehaviour
{
    private Transform player;

    [SerializeField]
    private GameObject poopPrefab;

    [SerializeField]
    private float spawnInterval = 1f;

    private void Start()
    {
        StartCoroutine(spawnFood(spawnInterval, poopPrefab));
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();

    }

    private IEnumerator spawnFood(float interval, GameObject poop)
    {
        yield return new WaitForSeconds(interval);
        GameObject newPoop = Instantiate(poop, player.position + new Vector3(1f,0,0), Quaternion.identity);
        StartCoroutine(spawnFood(interval, poop));
    }
}
