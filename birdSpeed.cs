using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using gStats;   

public class birdSpeed : MonoBehaviour
{
    // Start is called before the first frame update
    public gStats.GameStatus stats;

    void decreaseSpeed()
    {
        stats.birdSpeed = stats.birdSpeed - new Vector3(1 * stats.difficulty, 1 * stats.difficulty, 1 * stats.difficulty);
    }
    void increaseSpeed()
    {
        stats.pipeSpeed = stats.birdSpeed - new Vector3(1 * stats.difficulty, 1 * stats.difficulty, 1 * stats.difficulty);

    }
}
