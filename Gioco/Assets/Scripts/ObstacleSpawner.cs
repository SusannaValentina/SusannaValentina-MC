using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public float secondsLeftTillSpawn = 0;
    public float spawnSpeed;

    public float spawnChance;
    public GameObject obstPrefab;

    // Update is called once per frame
    void Update()
    {
        secondsLeftTillSpawn -= Time.deltaTime;
        int temp = Random.Range(0, 100);

        if(temp <= spawnChance && secondsLeftTillSpawn <= 0)
        {
            Instantiate(obstPrefab, new Vector3(15, Random.Range(-2.8f, -4.3f), 0), Quaternion.identity, transform);

            secondsLeftTillSpawn = spawnSpeed;
        }
    }
}
