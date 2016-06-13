using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.Collections;

public class NumberWizard : MonoBehaviour {

    int min= 1 ;
    int max = 1000;
    public int maxGuessesAllowed = 5;

    public Text text;

    int guess;


    // Use this for initialization
    void Start () {
        StartGame();
    }

    void StartGame()
    {
        guess = Random.Range(min, max);

        text.text = "Is your number higher or lower than "+guess+"?";

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
        //guess = (max + min) / 2;
        guess = Random.Range(min+1,max-1);
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
