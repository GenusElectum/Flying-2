using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using System.Threading;
using UnityEngine;
using gStats;

public class birdSize : MonoBehaviour
{
    public gStats.GameStatus stats;

    void decreaseSize()
    {
        stats.pipeSize = stats.birdSize - new Vector3(1 * stats.difficulty, 1 * stats.difficulty, 1 * stats.difficulty);
    }
    void increaseSize()
    {
        stats.pipeSize = stats.birdSize + new Vector3(1 * stats.difficulty, 1 * stats.difficulty, 1 * stats.difficulty);

    }
}
