using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Killer : MonoBehaviour
{
    [SerializeField] private GameObject spawn;

    private Spawner spawner;
    private void Start()
    {
        if(spawn.TryGetComponent<Spawner>(out spawner)) { }
    }

    private void OnTriggerEnter(Collider other)
    {
        GameObject.Destroy(other.gameObject);
            spawner.Spawn();

    }
}
