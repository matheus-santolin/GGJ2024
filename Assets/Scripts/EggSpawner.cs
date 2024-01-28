using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EggSpawner : MonoBehaviour
{
    public GameObject egg;
    public Transform spawnPoint;
    public Transform endPoint;
    public float spawnTime;
    private float timer;

    void Start()
    {
        timer = spawnTime;
    }

    
    void Update()
    {
        if (timer <= 0) 
        {
            SpawEgg();
            timer = spawnTime;
        }
        timer -= Time.deltaTime;
    }

    private void SpawEgg() 
    {
        GameObject _egg = Instantiate(egg, spawnPoint.position, 
            Quaternion.Euler(transform.rotation.x, transform.rotation.y, transform.rotation.z));
        _egg.transform.parent = this.transform;
    }
}
