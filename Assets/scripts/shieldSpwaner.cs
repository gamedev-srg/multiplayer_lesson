using System.Collections;
using UnityEngine;

/**
 * This component spawns the given object at fixed time-intervals at its object position.
 */
public class shieldSpwaner: MonoBehaviour {
    [SerializeField] GameObject prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [SerializeField] float timeBetweenSpawns = 20f;
    

    void Start() {
        this.StartCoroutine(SpawnRoutine());
    }

    private IEnumerator SpawnRoutine() {
        while (true) {
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(timeBetweenSpawns);
        }
    }
}