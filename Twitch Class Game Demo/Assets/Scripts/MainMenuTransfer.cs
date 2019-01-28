using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuTransfer : MonoBehaviour
{
    public Text GameLengthInput; //Input from text boxes
    public Text RedFontTimeThresholdInput;
    public Text GridWidthInput;
    public Text GridHeightInput;
    public Text StartButtonTextInput;
    public Text TuningButtonTextInput;
    int GameLengthLocal = 10; //"Boxes" for new entries to go into, likely could do it without them, but this setup works so I'm not touching it
    int RedFontTimeThresholdLocal = 5;
    int GridWidthLocal = 8;
    int GridHeightLocal = 5;
    string StartButtonTextLocal = "Start";
    string TuningButtonTextLocal = "Tuning Variables";

    //Activates when the save button is pushed, saves all new tweaked values to the Global class instansiation
    public void SaveTweaks()
    {
        if(GameLengthInput.text != "") //If statements check to make sure a change has been made, if no change made, old value is kept
        {
            int.TryParse(GameLengthInput.text, out GameLengthLocal); //take string from text entry and convert to integer
            Global.Instance.GameLength = GameLengthLocal; //put new int into global
        }
        if(RedFontTimeThresholdInput.text != "")
        {
            int.TryParse(RedFontTimeThresholdInput.text, out RedFontTimeThresholdLocal);
            Global.Instance.RedFontTimeThreshold = RedFontTimeThresholdLocal;
        }
        if(GridWidthInput.text != "")
        {
            int.TryParse(GridWidthInput.text, out GridWidthLocal);
            Global.Instance.GridWidth = GridWidthLocal;
        }
        if(GridHeightInput.text != "")
        {
            int.TryParse(GridHeightInput.text, out GridHeightLocal);
            Global.Instance.GridHeight = GridHeightLocal;
        }
        if(StartButtonTextInput.text != "")
        {
            Global.Instance.StartButtonText = StartButtonTextInput.text; //puts string directly into global
        }
        if(TuningButtonTextInput.text != "")
        {
            Global.Instance.TuningButtonText = TuningButtonTextInput.text;
        }
    }

    //Activates when Main button is pushed, brings you back to main menu
    public void MainTransfer()
    {
        SceneManager.LoadScene(sceneName: "MainMenu");
    }
}
