using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int score = 0;
    public Text pointsScoredText;
    public Text totalScoreText;

    public bool canClick = true;

    private BallScript ballScript;

    public ColorPallet colorPallet = new ColorPallet();

    public int[,] statusArray = new int [216, 2];

    private void Start()
    {
        ballScript = GameObject.Find("Sphere").GetComponent<BallScript>();
        // pointsScoredText = GameObject.Find("PointsScored").GetComponent<Text>();
        // totalScoreText = GameObject.Find("TotalScore").GetComponent<Text>();

    }

    private void Update()
    {
        //Keepts UI Score up to date

        totalScoreText.text = "Score: " + score;
    }

    public void scoreAndContinue(int points)
    {

        //Ensures players can't spam the mouse to get points.
        canClick = false;

        //Adds points to score
        score += points;

        //Turns on and populates the PointsScored UI.
        pointsScoredText.enabled = true;
        pointsScoredText.text = points + "points";

        //Waits two seconds
        StartCoroutine(wait(2));
    }

    IEnumerator wait(int seconds)
    {
        yield return new WaitForSeconds(seconds);

        // Turns of points scored UI.
        pointsScoredText.text = "";
        pointsScoredText.enabled = false;

        // Gets new color.
        ballScript.NewMatchColor();

        // Enables clicking again.
        canClick = true;
    }
}
