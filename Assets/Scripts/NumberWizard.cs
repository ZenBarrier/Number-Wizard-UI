using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    public int max;
    public int min;
    public Text text;

    int guess;

    public int maxGuessesAllowed = 5;

    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame()
    {
        guess = max/2;

        text.text = "Choose a number between "+min+" and "+max+"\n\n"+
                    "Is your number higher or lower than "+guess+"?";

        max++;
    }

    public void GuessHigher()
    {
        min = guess;
        NextGuess();
    }
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }

    public void CorrectGuess()
    {
        SceneManager.LoadScene("Lose");
    }

    void NextGuess()
    {
        guess = (max + min) / 2;
        text.text = "Is the number lower or higher than " + guess + "?";
        maxGuessesAllowed--;
        if (maxGuessesAllowed <= 0)
        {
            SceneManager.LoadScene("Win");
        }
    }
	
	// Update is called once per frame
	void Update () {
    }
}
