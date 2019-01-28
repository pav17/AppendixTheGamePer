using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceholderChanger : MonoBehaviour
{
    
    public Text GameLengthP; //Create boxes for place holder text on tuning screen
    public Text RedFontTimeThresholdP;
    public Text GridWidthP;
    public Text GridHeightP;
    public Text StartButtonTextP;
    public Text TuningButtonTextP;

    
    // Start is called before the first frame update
    void Start()
    {
        GameLengthP.text = Global.Instance.GameLength.ToString(); //make placeholder values match what is actually in Global, as tuning settings persist between games in one session.
        RedFontTimeThresholdP.text = Global.Instance.RedFontTimeThreshold.ToString();
        GridWidthP.text = Global.Instance.GridWidth.ToString();
        GridHeightP.text = Global.Instance.GridHeight.ToString();
        StartButtonTextP.text = Global.Instance.StartButtonText;
        TuningButtonTextP.text = Global.Instance.TuningButtonText;
    }
}
