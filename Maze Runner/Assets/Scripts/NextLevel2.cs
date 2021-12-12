using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel2: MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //Loads End Menu when player collides with object
    void OnCollisionEnter(Collision gameObjectInformation){
        if (gameObjectInformation.gameObject.name == "Player"){
            SceneManager.LoadScene("EndMenu");
        }
    }
}