using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    public float parallaxEffect = 0 ;
    public GameObject backgroundObject;
    public int spawned = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()

    {
        transform.position = transform.position + (Vector3.left * Time.deltaTime);
        
        if (transform.position.x <= -1 && spawned == 0)
        {
            Instantiate(backgroundObject, new Vector3(transform.position.x + 20.48f, 0, 0), transform.rotation); ;
            spawned = 1;
        }

        if (transform.position.x <= -20.48f)
        {
            Destroy(gameObject);
        }
    }

}
