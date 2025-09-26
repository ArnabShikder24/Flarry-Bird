using UnityEngine;

public class PipeSpawanScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2f;
    private float timer = 0f;
    public float offsetRange = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if(timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {

            spawnPipe();
            timer = 0f;
        }
    }

    void spawnPipe()
    {
        float randomY = Random.Range(-offsetRange, offsetRange);
        Vector3 spawnPos = new Vector3(transform.position.x, transform.position.y + randomY, 0);
        Instantiate(pipe, spawnPos, transform.rotation);
    }
}
