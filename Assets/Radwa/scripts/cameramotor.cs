using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameramotor : MonoBehaviour
{
    private Transform lookat;
    private Vector3 offset;
    private Vector3 movevector;
    private float transition = 0;
    private float animationDuration = 3;
    private Vector3 animationOffset=new Vector3(0,5,5);
    
    void Start()
    {
        //indecate the player and calculate the offset

      lookat=  GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
      offset = transform.position - lookat.position;
    }

   
    void Update()
    {
        //the camera follow the player 

        transform.position = lookat.position + offset;
        movevector = lookat.position + offset;
        movevector.x = 0;
        movevector.y = Mathf.Clamp(movevector.y, 3, 5);
        if (transition > 1)
        {
            transform.position = movevector;
        }
        else
        {
            //animation at the start of the game

            transform.position = Vector3.Lerp(movevector + animationOffset, movevector, transition);
            transition += Time.deltaTime * 1 / animationDuration;
            transform.LookAt(lookat.position + Vector3.up);
        }

        
    }
}
