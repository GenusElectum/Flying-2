using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using gStats;
using System.Timers;
using Unity.VisualScripting.Antlr3.Runtime.Misc;

public class PipeSpawner : MonoBehaviour
{

    public GameObject pipe;
    public gStats.GameStatus stats;

    public float spawnRate = 2;
    private float timer = 0;
    public float yMaxRange = 4;
    public float yMinRange = -4;
    public float yPosition;
    public float increaseRandom;
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            spawnPipe();
            timer = spawnRate;
        }
    }

    void spawnPipe()
    {
        yPosition = Random.Range(yMinRange, yMaxRange);
        if (yPosition + increaseRandom < 11 && stats.lastRandom < 5)
        {
                yPosition += Random.Range(0.5f , increaseRandom);

        }   
        else if(yPosition - increaseRandom > 3.7 && stats.lastRandom > 9)
        {
            yPosition -= Random.Range(0.5f, increaseRandom);
        }

        Instantiate(pipe, new Vector3(transform.position.x , yPosition , 0), transform.rotation);  
        stats.lastRandom = yPosition;


    }

}
