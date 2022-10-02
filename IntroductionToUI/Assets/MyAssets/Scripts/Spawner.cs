using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] private GameObject spawnObject;
    [SerializeField, Min(1)] private int spawnCount = 3;
    [SerializeField] private float spawnDelay;

    private Vector3 spawnPosition;
    private void Start()
    {
        spawnPosition = GetComponent<Spawner>().gameObject.transform.position;
        for(int i = 0; i < spawnCount; i++) { Spawn(); }
    }

    public void Spawn() 
    {
        Vector3 spawnPos = new Vector3(Random.Range(spawnPosition.x - 50, spawnPosition.x + 50), Random.Range(spawnPosition.y, spawnPosition.y + 50), Random.Range(spawnPosition.z - 50, spawnPosition.z + 50));
        Quaternion rotation = new Quaternion(Random.Range(-90,90), Random.Range(-90, 90), Random.Range(-90, 90), Random.Range(-90, 90));

        Debug.Log(spawnPos);

        Instantiate(spawnObject, spawnPos, rotation);
    }
}
