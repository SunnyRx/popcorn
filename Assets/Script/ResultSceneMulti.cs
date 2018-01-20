using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResultSceneMulti : MonoBehaviour {

    public void PlayAgainMulti()
    {
        SceneManager.LoadScene("MultiPlay");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Title");
    }


}
