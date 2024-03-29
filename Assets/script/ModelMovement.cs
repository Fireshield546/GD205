using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = new Vector3( Input.GetAxis("Horizontal"), 0,Input.GetAxis("Vertical" ));
        GetComponent<Animator>
        //if (Input.GetKey(KeyCode.W))
        {
            //GetComponent<Animator>().SetFloat("Movement", 1f);

            //else GetComponent
            
        }
    }
}
