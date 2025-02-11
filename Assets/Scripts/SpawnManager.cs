using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(40,0.3f,-1.3f); 
    private float spawnDelay = 2.0f;
    private float repeatRate = 2.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnDelay, repeatRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObstacle(){
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
