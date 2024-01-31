using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using lightControl;

public class BirdScript : MonoBehaviour
{
    public Rigidbody rbD;
    public float flapStrength;
    private ParticleSystem ps;
    private float restartParticle = 1;
    public lightControl.LightController lControl;

    // Start is called before the first frame update
    void Start()
    {

        ps = GetComponent<ParticleSystem>();
        var main = ps.main;
        main.simulationSpeed = 0.2f; // Change this to your desired speed

    }



    // Update is called once per frame
    void Update()
    {

        if (restartParticle < 0) 
        {
            ps.Clear();
            ps.Play();
            restartParticle = 1;
            lControl.ChangeC();
        }
        
        restartParticle -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            rbD.velocity = Vector2.up * flapStrength; 
        
        }


    }
}
