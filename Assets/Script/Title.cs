using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour {

    public void Config()
    {
        Debug.Log("Config");
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }

    public void SoloPlay()
    {
        SceneManager.LoadScene("SoloPlay");
        FindObjectOfType<AudioManager>().Stop("BGM");
        FindObjectOfType<AudioManager>().Play("GameBGM");
    }

    public void MultiPlay()
    {
        SceneManager.LoadScene("MultiPlay");
        FindObjectOfType<AudioManager>().Stop("BGM");
        FindObjectOfType<AudioManager>().Play("GameBGM");
    }


}
