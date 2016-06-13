using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int max;
    int min;
    int guess;

    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame()
    {
        min = 1;
        max = 1000;
        guess = 500;
        print("=============================");
        print("Welcome to number wizard!");
        print("Pick a number in your head, but don't tell me.");

        print("The highest number is " + max);
        print("The lowest number is " + min);

        print("Is the number lower or higher than " + guess + "?");
        print("Up = higher, Down = lower, Return = equal");

        max++;
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        print("Is the number lower or higher than " + guess + "?");
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            NextGuess();
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            print("I won!");
            StartGame();
        }
    }
}
