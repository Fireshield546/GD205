using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boardmovement : MonoBehaviour
{
    public Transform hazard;

    // Vector3 (stores 3D positions) called startPos
    //we will use it to store our initial position
    Vector3 startPos;

   

    // Start is called before the first frame update
    void Start()
    { 
    
        //use our initial transform.position for startPos
        //we do it in start since that runs before players start playing
        startPos = transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        //if our transform.position (the position of the transform of whatever this is attached to) ...
        //...is the same as our hazards position, then do whats in the curly brackets
        if (transform.position == hazard.position)
        {

            Debug.Log("HAZARD OUCH");
            //Destroy(gameObject); //demonstration of how to destroy the player piece

            //use our startPos we set inside start as our new position, resetting it back to the beginning
            transform.position = startPos;
        }
        {
            //movement//
            if (Input.GetKeyDown(KeyCode.W))
            {
                transform.position += new Vector3(-1f, 0f, 0f);
            }
            if (Input.GetKeyDown(KeyCode.A))
            {
                transform.position += new Vector3(0f, 0f, -1f);
            }
            if (Input.GetKeyDown(KeyCode.S))
            {
                transform.position += new Vector3(1f, 0f, 0f);
            }
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.position += new Vector3(0f, 0f, 1f);
            }

        }
    }
}

