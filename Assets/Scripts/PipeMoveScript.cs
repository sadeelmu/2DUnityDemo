using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMoveScript : MonoBehaviour
{
    public float moveSpeed = 5;


    //variable used to delete the pipes in order to preserve memory
    private float deadZone= -50;

    void Start()
    {}

    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;

        //if the pipes position on the x axis reaches beyond the dead zone we delete it
        if(transform.position.x<deadZone){
            Destroy(gameObject);
        }
    }
}
