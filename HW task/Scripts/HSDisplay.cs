using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HSDisplay : MonoBehaviour
{
        public int finalscore;
        public TMP_Text hsd;
 

    // Update is called once per frame
    void Update()
    {   finalscore = deathTriggerEnter.finalhighScore;
        hsd.SetText("Your Final Score: " + finalscore.ToString());
    }
}
