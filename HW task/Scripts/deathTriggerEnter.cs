using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class deathTriggerEnter : MonoBehaviour
{   
    public static int finalhighScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other) {
        if(other.gameObject.tag=="Player")
        {   finalhighScore = scoreCounter.totalScore;
            SceneManager.LoadScene("GameOver");
        }
    }
}
