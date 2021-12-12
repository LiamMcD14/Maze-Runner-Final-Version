using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{

    public void End ()
    {
        //Load Last Ui - End Menu
        SceneManager.LoadScene("Menu");
    }

}
