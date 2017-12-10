using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyPad : MonoBehaviour {

    public string code;//This is the code that needs to be inputted in order to open the door.
    public string inputString;//This is what is inputted into the keypad by the player - the string versrion used for the code
    public Text input;//This is what is inputted into the keypad by the player - the visual text seen on the keypad itself
    public bool doorUnlock = false;//The boolean to control whether or not the door is locked

	// Use this for initialization
	void Start () {
        input = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
		
        /*if(input == code)
        {
            doorUnlock = true;//This code should move into the function for the green button.
        }*/

        if(doorUnlock == true)//This is where the door will open with the correct code inputted
        {
            //Code to animate the door opening here
        }

	}

    public void NumberClick(string number)//Each button press inserts a character into the input string, depending on which button is pressed.
    {
        //In my mind, I was thinking something along the lines of:
        //input.text = input.text+"number"
        //Where number is basically the button number on the keypad being passed through as an argument.
    }

    public void CheckClick()//The green button should check the input string with an IF statement.
    {
        if(inputString == code)
        {
            doorUnlock = true;//This code should move into the function for the green button.
        }

        else
        {
            input.text = "";//Clear the textbox on wrong input
        }
    }

    public void ClearClick()//The clear button should clear the input string
    {
        input.text = "";
    }
}
