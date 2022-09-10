using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class survivalScore : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.name=="Doofus");
        {
            scoreCounter.totalScore+=1;
        }
    }
}
