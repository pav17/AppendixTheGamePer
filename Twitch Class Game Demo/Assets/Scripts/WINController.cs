using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WINController : MonoBehaviour
{
    public Text TimerText; //Box to enter Label

    public void Start()
    {
        TimerText.text = ("You had: " + Global.Instance.Time.ToString() + " Seconds left"); //Displays how much time player had left when they won
    }

    public void MainMenu() //Returns player to main menu screen for another game when Main Menu Button is Pressed
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }
}
