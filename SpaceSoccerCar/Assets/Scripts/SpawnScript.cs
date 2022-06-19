using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{

    public GameObject[] spawnObject;
    public Transform[] spawnLocation;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < spawnLocation.Length; i++)
        {
            Instantiate(spawnObject[Random.Range(0, spawnObject.Length)], spawnLocation[i]);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
