using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinBehavior : MonoBehaviour
{
    void OnMouseDown() //Activates when player clicks winning box
    {
        if (gameObject.tag == "Winner")
        {
            SceneManager.LoadScene(sceneName: "WinScreen"); //Takes Player to Win Screen
        }
    }
}
