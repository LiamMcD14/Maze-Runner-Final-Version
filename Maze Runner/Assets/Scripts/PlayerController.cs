using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 4.0f;
    private float turnSpeed = 100.0f;
    private float horizontalInput;
    private float forwardInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //this is where we get user input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        //Moving our Player forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        //Turning the Player around
        transform.Rotate(Vector3.up, horizontalInput * turnSpeed * Time.deltaTime);
        
    }
}