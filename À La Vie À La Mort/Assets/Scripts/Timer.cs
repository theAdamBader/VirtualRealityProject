using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//With reference to https://www.youtube.com/watch?v=D-6BbUozuCY and https://answers.unity.com/questions/1174761/20-minute-countdown-timer.html



public class Timer : MonoBehaviour {

    public Text timerText;

    public float timeLimit = 90.0f;//Variable for the time limit in seconds. 90sec/1:30min is just an example;change as necessary

	// Use this for initialization
	void Start () {
        timerText = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        //Text
        
        string min = Mathf.Floor(timeLimit / 60).ToString("00");
        string sec = (timeLimit % 60).ToString("00");
        timerText.text = min + ":" + sec;

        if (timeLimit <= 0.0f)//Out of time
        {
            timerText.text = "00" + ":" + "00";
            //Change GameState here?
        }
        else
        {
            timeLimit -= Time.deltaTime;//Time deducts per frame only if counter is more than 0.
        }
	}
}
