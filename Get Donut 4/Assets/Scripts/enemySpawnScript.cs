using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemySpawnScript : MonoBehaviour
{
    float spawnSpeed = 0.0f;
    bool justSpawned = false;
    bool firstTime = true;
    [SerializeField] float timeToWaitBeforeSpawn = 2.0f;
    [SerializeField] GameObject enemyToSpawn;

    IEnumerator wait()
    {
        if(!firstTime) Instantiate(enemyToSpawn, gameObject.transform.position, Quaternion.identity, gameObject.transform);
        justSpawned = true;
        yield return new WaitForSeconds(Random.Range(0.5f, 2.0f) + timeToWaitBeforeSpawn - spawnSpeed);
        firstTime = false;
        justSpawned = false;
    }
    void Update()
    {
        if (Time.realtimeSinceStartup % 3 == 0 && spawnSpeed <= 2.0f) spawnSpeed += 0.1f;
        if (justSpawned == false)StartCoroutine(wait());
    }
}
