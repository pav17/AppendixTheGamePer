using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StartGame : MonoBehaviour
{
    //Declare Our Text boxes so we can edit them from the tuning menu
    public Text StartButtonText;
    public Text TuningButtonText;
   
    // Update is called once per frame
    void Update()
    {
        if (StartButtonText.text != Global.Instance.StartButtonText) //Checks to see if Text for buttons has changed, and chages it if neccissary
        {
            StartButtonText.text = Global.Instance.StartButtonText;
        }
        if(TuningButtonText.text != Global.Instance.TuningButtonText)
        {
            TuningButtonText.text = Global.Instance.TuningButtonText;
        }
    }

    //Resets Timer and changes scene to the actual game
    public void Play()
    {
        Global.Instance.Time = (float)Global.Instance.GameLength;
        SceneManager.LoadScene(sceneName: "Gameplay");
    }

    //Changes Scene to Tuning Screen
    public void Options()
    {
        SceneManager.LoadScene(sceneName: "TuningScreen");
    }

    
}
