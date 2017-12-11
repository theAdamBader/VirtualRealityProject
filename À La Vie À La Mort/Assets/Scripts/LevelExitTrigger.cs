using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelExitTrigger: MonoBehaviour {

    public bool triggered;
    // Use this for initialization
    void Start () {
        triggered = false;
	}
	
	// Update is called once per frame
	void Update () {
	}


    void OnTriggerEnter(Collider other)//the only other game objec with is trigger on to activate this is the OVR camera
    {
        triggered = true;
    }
}
