using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject circle;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    //public int circleCount = 0;

    public float spawnInterval = 5f;
    private float spawnCountdown = 0;


    // Start is called before the first frame update
    void Start()
    {
        SpawnRandomCircle();
        spawnCountdown = spawnInterval;
    }

    // Update is called once per frame
    void Update()
    {
        if (spawnCountdown <= 0)
        {
            SpawnRandomCircle();
            spawnCountdown = spawnInterval;
            //circleCount += 1;
        }
        else
        {
            spawnCountdown -= Time.deltaTime;
        }
        
    }

    public void SpawnRandomCircle()
    {
        Instantiate(circle, new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY)), Quaternion.identity);
        //circleCount += 1;
    }

}
