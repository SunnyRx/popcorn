using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultScene : MonoBehaviour {

    public int convertedScore;
    public Text FinalScore;
    public Text HighScore;

    private void Start()
    {
        convertedScore = GameObject.Find("GameSystem").GetComponent<GameSystem>().score;
        FinalScore.text = convertedScore.ToString();
        HighScore.text = convertedScore.ToString();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
        FindObjectOfType<AudioManager>().Stop("GameBGM");
        FindObjectOfType<AudioManager>().Play("BGM");
    }

}
