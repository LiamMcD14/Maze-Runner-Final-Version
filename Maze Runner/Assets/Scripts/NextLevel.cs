using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLevel: MonoBehaviour
{

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    //On Collision with object, Scene changes to Level 02
    void OnCollisionEnter(Collision gameObjectInformation){
        if (gameObjectInformation.gameObject.name == "Player"){
            SceneManager.LoadScene("Level02");
        }
    }
}