using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PulpitSpawner : MonoBehaviour
{   public GameObject pulpitPrefab;
    public float respawnTime = 2.5f;
    private int xcoord = 0;
    private int zcoord = 0;
    // Start is called before the first frame update
    
    private void spawnPulpit(Vector3 curPos){
        //Debug.Log(curPos);
        GameObject x = Instantiate(pulpitPrefab) as GameObject;
        x.transform.position = new Vector3(10,0,0) + curPos;
    IEnumerator planespawn(){
        while(true){
            yield return new WaitForSeconds(respawnTime);
            Vector3 curPos = new Vector3(23f,0.0f,0.0f); //dummy value for now
            curPos = GameObject.FindGameObjectWithTag("currentPulpit").transform.position;
            spawnPulpit(curPos);
        }
    }
    void Start()
    {
        StartCoroutine(planespawn());
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
}