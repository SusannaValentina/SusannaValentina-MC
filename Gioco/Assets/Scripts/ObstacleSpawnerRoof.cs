using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawnerRoof : MonoBehaviour
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

        if (temp <= spawnChance && secondsLeftTillSpawn <= 0)
        {
            Instantiate(obstPrefab, new Vector3(15, Random.Range(3.8f, 3.8f), 0), Quaternion.identity, transform);

            secondsLeftTillSpawn = spawnSpeed;
        }
    }
}
