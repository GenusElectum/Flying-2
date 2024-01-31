using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace gStats
{
    public class GameStatus : MonoBehaviour
    {
        public Vector3 pipeSize = new Vector3(1, 5, 1);
        public Vector3 pipeSpeed = new Vector3(1, 0, 0);
        public Vector3 birdSize = new Vector3(1, 0, 0);
        public Vector3 birdSpeed = new Vector3(1, 1, 1);
        public int lifeAvailable = 1;
        public int pipeScore = 0;
        public int appliedEffect = 0;
        public float difficulty = 0;
        public float lastRandom;

        // Start is called before the first frame update
        void Start()
        {
            Debug.Log(name);
        }
    }
}