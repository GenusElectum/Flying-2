using UnityEngine;
using gStats;

public class PipeMoveScript : MonoBehaviour
{
    // Reference to the GameStats script
    public gStats.GameStatus stats;
    // Update is called once per frame




    void Update()
    {
        if (name != "Pipes")
        {
            float newXPosition = transform.position.x - stats.pipeSpeed.x * Time.deltaTime;
            transform.position = new Vector3(newXPosition, transform.position.y, transform.position.z);
        }

        if (transform.position.x < -20 && name != "Pipes") 
        { 

            Destroy(gameObject);

        }


    }
}