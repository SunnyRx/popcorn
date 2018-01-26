using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ResultSceneMulti : MonoBehaviour {
    public int convertedScore;
    public Text FinalScore;
    public Text HighScore;

    private void Start()
    {
        convertedScore = GameObject.Find("GameSystem").GetComponent<GameSystem>().score;
        FinalScore.text = convertedScore.ToString();
        HighScore.text = convertedScore.ToString();
    }
    
    public void PlayAgainMulti()
    {
        SceneManager.LoadScene("MultiPlay");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }


}
