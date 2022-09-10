using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPulpit : MonoBehaviour
{
    public float interval;
    //public float dtime = 2.0f;
    //private float timer = 0.0f;
    // Update is called once per frame
    void Update()
    {
        if (interval > 0){
            interval -=Time.deltaTime;
        }
        else {
            enabled=false;

            gameObject.AddComponent<Rigidbody>();
            gameObject.tag="dead";
            Destroy(gameObject,1);
            //timer+=Time.deltaTime;
            //if(timer>dtime){
            //    timer=0f;
            //    Destroy(gameObject);
            //}
        }
    }

}
