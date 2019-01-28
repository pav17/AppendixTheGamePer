using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoseBehavior : MonoBehaviour
{
    public Text Timer; //Creates Box for Timer Label
    void Update()
    {
        Global.Instance.Time -= Time.deltaTime; //Subtract appropriate amount of time every frame
        Timer.text = Global.Instance.Time.ToString(); //Display time left
        if(Global.Instance.Time <= Global.Instance.RedFontTimeThreshold) //check to see if text should turn red
        {
            Timer.color = Color.red; //if it should, do so
        }
        if(Global.Instance.Time < 0) //Check to see if player is out of time
        {
            SceneManager.LoadScene(sceneName: "LoseScreen"); //if they are, send them to lose screen
        }
    }
}
