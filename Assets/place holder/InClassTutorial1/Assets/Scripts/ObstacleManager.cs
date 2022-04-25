using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//I was helped by my friend
public class ObstacleManager : MonoBehaviour
{
    public GameObject[] objectPrefabs;
    private float spawnRangeX = 10;
    private float spawnRangeZ = 200;

    void Start()
    {
        for(int i = 0; i < 42; i++)
        {

        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(25, spawnRangeZ));
            int objectIndex = Random.Range(0, objectPrefabs.Length);
        //spawn objects at different spots on the road
        Instantiate(objectPrefabs[objectIndex], spawnPos, objectPrefabs[objectIndex].transform.rotation);
        }
    }

    // Update is called once per frame
    void Update()
    {
      
            
            
       
    }
}
