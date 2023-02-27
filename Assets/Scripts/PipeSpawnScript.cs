using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    //create reference to the prefab created
    public GameObject pipe;

    //timer to spawn pipes at intervals
    private float spawnRate = 5; 

    //counter
    private float timer = 0;

    //variable to randomize spawn heights
    private float heightOffset = 5;


    void Start()
    {
        //spawn the pipe once at the begining of the game
        spawnPipe();

    }

    void Update()
    {
        if (timer < spawnRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
        //spawn pipes
        spawnPipe();
        //reset counter
        timer=0;
        }

    }

    void spawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation);
    }
}
