using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gemma : MonoBehaviour
{
    private float secondsLeftTillSpawn = 0;
    public float spawnSpeed = 30;

    public float spawnChance;
    public GameObject obstPrefab;



    public bool goUp;
    public float speed = 1;

    void Start()
    {
        StartCoroutine(SwitchDirector());
    }

    // Update is called once per frame
    void Update()
    {
        secondsLeftTillSpawn -= Time.deltaTime;
        int temp = Random.Range(0, 100);

        if (temp <= spawnChance && secondsLeftTillSpawn <= 0)
        {
            Instantiate(obstPrefab, new Vector3(15, Random.Range(1f, -1f), 0), Quaternion.identity, transform);

            secondsLeftTillSpawn = spawnSpeed;
        }




        if (goUp)
        {
            transform.position = transform.position + new Vector3(0, speed * Time.deltaTime, 0);
        }
        else
        {
            transform.position = transform.position - new Vector3(0, speed * Time.deltaTime, 0);
        }

    }

    IEnumerator SwitchDirector()
    {
        while (gameObject.activeSelf)
        {
            yield return new WaitForSeconds(0.5f);
            goUp = !goUp;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            OnPicked(other);
        }
    }

    protected virtual void OnPicked(Collider other)
    {
        GetComponent<Collider>().enabled = false;
        Debug.Log("Hai preso: " + gameObject.name);
    }
}
