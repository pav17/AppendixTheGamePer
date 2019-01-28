using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LOSEController : MonoBehaviour
{
    public void MainMenu() //Returns Player to Main Menu Screen when Main Menu Button is pressed
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }
}
