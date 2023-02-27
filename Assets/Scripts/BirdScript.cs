using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    //create a reference to the component RigidBody 2D
    public Rigidbody2D myRigidbody;

    //to reference the logic manager script
    public LogicManagerScript logic;
    
    //birdisalive check
    public bool birdisalive = true;

    //variable to control strength of jump
    public float flyStrength;

    void Start()
    {
        logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();   
    }
    
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space) ==true && birdisalive==true)
        {
            myRigidbody.velocity = Vector2.up * flyStrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        logic.gameOver(); 
        birdisalive=false;
    }
}
