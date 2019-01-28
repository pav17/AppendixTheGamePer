using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CubeClicker : MonoBehaviour
{
    Material CubeColor; //Creates box for material
    
    private void Start()
    {
        CubeColor = GetComponent<Renderer>().material; //Load Material into script at start of game
    }
    private void OnMouseDown()
    {
        if(gameObject.tag == "Looser") //If box is clicked and is not winner, turns it red
        {
            CubeColor.color = Color.red;
        }
        else if(gameObject.tag == "Winner") //If box is clicked and is winner turns it green
        {
            CubeColor.color = Color.green;
        }
    }
}
