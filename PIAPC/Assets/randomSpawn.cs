using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawn : MonoBehaviour
{
    public GameObject libro;

    void Start()
    {
        libro = GetComponent<GameObject>();
        spawnRandom();
    }

    void spawnRandom()
    {
        Vector3 randomPos = new Vector3(Random.RandomRange(15f, 22f), 0.1f, Random.RandomRange(-4f, -22f));
        Instantiate(libro, randomPos, Quaternion.identity);
    }

}


