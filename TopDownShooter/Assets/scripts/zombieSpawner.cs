using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class zombieSpawner : MonoBehaviour
{
    public GameObject ZombieePrefab;
    public int waveSize;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnMany", .5f, 5);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    Vector3 RandomCircle(Vector3 center, float radius)
    {
        float ang = Random.value * 360;
        Vector3 pos;
        pos.x = center.x + radius * Mathf.Sin(ang * Mathf.Deg2Rad);
        pos.y = center.y + radius * Mathf.Cos(ang * Mathf.Deg2Rad);
        pos.z = center.z;
        return pos;
    }

    void SpawnMany()
    {
        for (int i = 0; i < waveSize; i++)
        {
            Spawn();
        }
        waveSize += 2;
    }

    void Spawn()
    {
        Vector2 position = RandomCircle (Vector3.zero, 20);
        Instantiate(ZombieePrefab, position, Quaternion.identity);
    }
}
