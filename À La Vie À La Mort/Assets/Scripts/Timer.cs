using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    float timeLimit = 30.0f;//Variable for the time limit in seconds. 30 is just an example;change as necessary

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLimit -= Time.deltaTime;//Time deducts per frame.
        if(timeLimit < 0)//Out of time
        {
            //Change GameState here?
        }
	}
}
