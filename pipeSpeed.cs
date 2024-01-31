using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;
using gStats;

public class pipeSpeed : MonoBehaviour
{
    public gStats.GameStatus stats;

    void decreaseSpeed()
    {
        stats.pipeSpeed = stats.pipeSpeed - new Vector3(1 * stats.difficulty, 1 * stats.difficulty, 1 * stats.difficulty);
    }
    void increaseSpeed()
    {
        stats.pipeSpeed = stats.pipeSpeed - new Vector3(1 * stats.difficulty, 1 * stats.difficulty, 1 * stats.difficulty);

    }
}
