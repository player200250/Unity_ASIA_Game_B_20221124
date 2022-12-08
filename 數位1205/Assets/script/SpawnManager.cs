using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(25, 0 , 0);

    public float delaytime = 5f;
    public float repeatTime = 2;


    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("ObstacleSpawn", delaytime, repeatTime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void ObstacleSpawn()
    {
        Instantiate(obstaclePrefab, spawnPos, transform.rotation);
    }

}
