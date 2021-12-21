using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpawner : MonoBehaviour
{
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] float timeBetweenSpawns = 20f;
    [SerializeField] GameObject[] spawnPosition;


    void Start()
    {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine()
    {
        int randomTarget = Random.Range(0, spawnPosition.Length);
        while (true)
        {
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, spawnPosition[randomTarget].transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
}
