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
    }

    public void MultiPlay()
    {
        SceneManager.LoadScene("MultiPlay");
    }


}
