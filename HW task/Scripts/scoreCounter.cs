using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCounter : MonoBehaviour
{
    public static int totalScore;
    void start(){
        totalScore=0;
    }
    private void OnGUI()
    {
        GUI.Box (new Rect (0,0,100,20), "Score: " + totalScore.ToString());
    }
    
 }