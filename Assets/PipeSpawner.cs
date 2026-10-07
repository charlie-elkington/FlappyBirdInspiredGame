using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject Pipe;
    public float SpawnRate = 2;
    private float Timer = 0;
    public float HeightOffset = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(Timer < SpawnRate)
        {
            Timer += Time.deltaTime;
        }
        else
        {
            SpawnPipe();
            Timer = 0;
        }
        
        
    }

    void SpawnPipe() 
        {
            float LowestPoint = transform.position.y - HeightOffset;
            float HighestPoint = transform.position.y + HeightOffset;
            Instantiate(Pipe, new Vector3(transform.position.x, Random.Range(LowestPoint, HighestPoint ), 0), transform.rotation);
        }
}
