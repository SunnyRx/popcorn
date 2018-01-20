using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameSystem : MonoBehaviour {

    private bool isPause;
    public Text pauseText;
    public int score;
    public Text scoreText;

    static GameSystem _instance;

    static public GameSystem getInstance()
    {
        if (!_instance)
        {
            _instance = new GameSystem();
        }
        return _instance;
    }

    static public void destoryInstance()
    {

    }

    // Use this for initialization
    void Start () {
        _instance = this;
        isPause = false;
        pauseText.text = "";
        score = 0;
        setScore(0);

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown("escape"))
        {
            if (!isPause)
            {
                isPause = true;
                pauseText.text = "一時停止";
                Time.timeScale = 0f;
            }
            else
            {
                isPause = false;
                pauseText.text = "";
                Time.timeScale = 1f;
            }
        }
    }

    public void setScore(int tmpScore)
    {
        score += tmpScore;
        scoreText.text = "スコア: " + score.ToString();
    }
}
