using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerScript : MonoBehaviour
{
    public LogicManagerScript logic;


    void Start()
    {
     logic=GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();   
    }

    void Update()
    {
        
    }
 
    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if(collision.gameObject.layer ==3)
        {
            logic.addScore(1);
        }
    }
}
