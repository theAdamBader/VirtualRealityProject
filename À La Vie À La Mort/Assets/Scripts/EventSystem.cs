﻿//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;
//using UnityEngine.SceneManagement;

//public class EventSystem : MonoBehaviour
//{

//    public static int gameState;
//    public GameObject text;
//    private Timer scriptForReference;
//    private bool gameOver;
//    // Use this for initialization
//    void Start()
//    {
//        gameState = 0;
//        scriptForReference = text.GetComponent<Timer>();
//        gameOver = scriptForReference.gameOver;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        print("fine");
//        if (gameOver == true)
//        {
//            gameState = 1;
//            SceneManager.LoadScene("level1", LoadSceneMode.Single);
//            gameOver = false;
//            print("not");
//        }
//    }
//}
