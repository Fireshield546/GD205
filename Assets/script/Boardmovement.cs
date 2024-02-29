using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boardmovement : MonoBehaviour
{
    public Transform exit;

    //declare an array of hazards instead so we can work smarter, not harder
    //we dont need to declare the number of positions like you did in GD105, because making it public..
    //...we can change the number in the inspector, which is very helpful
    public Transform[] hazards;

    // Vector3 (stores 3D positions) called startPos
    //we will use it to store our initial position
    Vector3 startPos;

    public AudioClip deathsound;
    AudioSource ded;

    public AudioClip escape;
    AudioSource win;

    // Start is called before the first frame update
    void Start()
    {
        win = GetComponent <AudioSource>();
        ded = GetComponent <AudioSource>();
        //use our initial transform.position for startPos
        //we do it in start since that runs before players start playing
        startPos = transform.position;

    }
    // Update is called once per frame
    void Update()
    {
        { //we create a new for loop
          //reminder that the three parts inside the parentheses are:
          //1. A declaration and initial value (we use an integer called i by convention, which will allow us to iterate through)
          //2. A condition for determining if the loop should run an additional time, if true, run again
          //3. An update to our variable ... by increasing it by one, we can count through each hazard in our array
            for (int i = 0; i < hazards.Length; i++)
            {

                //this is the same as our previous example, except we are checking the array, using the square brackets with the position inside of them
                //the first time this runs, i will be 0, the second time itll be 1, etc.
                if (transform.position == hazards[i].position)
                {

                    ded.PlayOneShot(deathsound, 0.5f);
                    Debug.Log("HAZARD OUCH");
                    //Destroy(gameObject); //demonstration of how to destroy the player piece

                    //use our startPos we set inside start as our new position, resetting it back to the beginning
                    transform.position = startPos;
                }
            }
                if (transform.position == exit.position)
               {
                win.PlayOneShot(escape,0.9f);
                Debug.Log("you made it");

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
}


