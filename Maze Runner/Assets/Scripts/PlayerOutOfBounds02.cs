using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOutOfBounds02 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //When player goes out of bounds, player respawns at starting location
        if (transform.position.y < -1)
        {
            transform.position = new Vector3( 1, 1, 0);
        }
    }

}