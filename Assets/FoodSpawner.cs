using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject foodPrefab;

    [SerializeField]
    private float spawnInterval = 5f;

    private void Start()
    {
        StartCoroutine(spawnFood(spawnInterval, foodPrefab));
    }

    private IEnumerator spawnFood(float interval, GameObject food)
    {
        yield return new WaitForSeconds(interval);
        GameObject newFood = Instantiate(food, new Vector3(Random.Range(-8.6f, 8.6f), Random.Range(-4f, 4f), 0), Quaternion.identity);
        StartCoroutine(spawnFood(interval, food));
    }
}
