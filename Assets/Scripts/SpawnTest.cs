using UnityEngine;

public class SpawnTest : MonoBehaviour
{

    public GameObject objetoSpawn;

    public Vector3 spawnPosition;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Instantiate(objetoSpawn, spawnPosition, transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
