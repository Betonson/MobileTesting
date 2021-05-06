using UnityEngine;

public class SpawnController : MonoBehaviour
{
    [SerializeField] private GameObject circle;

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    public float spawnInterval = 5f;
    private float spawnCountdown = 0;

    void Start()
    {
        SpawnRandomCircle();
        spawnCountdown = spawnInterval;
    }

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
