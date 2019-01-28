using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePlacerPositive : MonoBehaviour
{
    public Transform CubeWinner; //create spaces to put cubes
    public Transform CubeLooser;
    public float WinnerChance; //Create space to adjust odds of winner box being placed
    float WinnerPlacement; //Used to determine if a certain cube is the winner
    bool WinnerPlaced = false; //tells program when winner has been placed
    // Start is called before the first frame update
    void Start()
    {
        for (int y = 0; y < Global.Instance.GridHeight; ++y) //Rows
        {
            for (int x = 0; x < Global.Instance.GridWidth; ++x) //Columns
            {
                WinnerPlacement = Random.Range(0.0f, 1.0f); //Use random number generator to determine if winner is placed
                if(WinnerPlacement <= WinnerChance && WinnerPlaced == false)
                {
                    Instantiate(CubeWinner, new Vector3(x * 2, y * 2, 0), Quaternion.identity); //Place Winner
                    WinnerPlaced = true;
                    Debug.Log("Winner 1");
                }
                else if(WinnerPlacement > WinnerChance && y != Global.Instance.GridHeight-1 && x != Global.Instance.GridWidth-1)
                {
                    Instantiate(CubeLooser, new Vector3(x * 2, y * 2, 0), Quaternion.identity); //Place Looser
                    Debug.Log("Looser 1");
                }
                else if(y == Global.Instance.GridHeight-1 && x == Global.Instance.GridWidth-1 && WinnerPlaced == false)
                {
                    Instantiate(CubeWinner, new Vector3(x * 2, y * 2, 0), Quaternion.identity); //Place Winner in last cube if no winner placed yet
                    WinnerPlaced = true;
                    Debug.Log("Winner 2");
                }
                else
                {
                    Instantiate(CubeLooser, new Vector3(x * 2, y * 2, 0), Quaternion.identity); //Was having some wierdness with no winner spawning, this should fix it but may not have
                    Debug.Log("Looser 2");
                }
            }
        }
    }
}
