using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventSystem : MonoBehaviour
{

    //public static int gameState;
    public GameObject text;
    public GameObject fadeToBlack;//UI element that makes screen fade to black
    public GameObject endSlate;//Text showing congratulations
    public GameObject LevelExitTrigger;//game object at end of level with collider
    private Timer timeScript;
    private LevelExitTrigger exitScript;
    private bool triggered;//Bool showing if you have stepped outside the door and won
    private bool gameOver;//Bool showing whether or not time has run out
    private float a;//Alpha colour value

    // Use this for initialization
    void Start()
    {
        //gameState = 0;
        timeScript = text.GetComponent<Timer>();
        exitScript = LevelExitTrigger.GetComponent<LevelExitTrigger>();//get the script for the corresponding game object

    }

    // Update is called once per frame
    void Update()
    {

        gameOver = timeScript.gameOver;//Updates the variable in the Event system with the one in the timer
        if (gameOver == true)
        {
            //gameState = 1;
            SceneManager.LoadScene("level1", LoadSceneMode.Single);
        }

        triggered = exitScript.triggered;//Updates according to the level trigger
        if (triggered == true)
        {
            endSlate.GetComponent<Renderer>().material.color = new Color(1, 1, 1, a);//Should set the colour of text to be white
            fadeToBlack.GetComponent<Renderer>().material.color = new Color(0, 0, 0, a);//Should set the colour of the background to be black
            a += 0.05f;//Increase the alpha value so that the scene gradually changes after leaving
            //then after some time use same code to load level from gameOver state
            print("test");
            //if (a => 4){
            //gameOver = true;//This would make the game restart
            //}
        }
    }
}
