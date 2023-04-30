using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float movespeed;
    public float x, y;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Get the horizontal and vertical axis.
        // By default they are mapped to the arrow keys.
        // The value is in the range -1 to 1
        // Note: The Horizontal and Vertical ranges change from 0 to +1 or -1 with increase/decrease in 0.05f steps.
        //      GetAxisRaw has changes from 0 to 1 or -1 immediately, so with no steps.
        y = Input.GetAxisRaw("Vertical");

        // Create a new Vector3 to capture current vertical input
        Vector3 movement = new Vector3(0, y, 0); // Instantiate a new vector3 to capture

        // Translate player position scaled with pre-defined movespeed and the time measured between frames
        transform.Translate(movement * movespeed * Time.deltaTime);
    }
}
