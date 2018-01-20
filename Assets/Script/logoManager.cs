using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class logoManager : MonoBehaviour {

    public Image logo;

    // Use this for initialization
    void Start()
    {
        fadein();




    }

    // Update is called once per frame
    void Update () {
        
    }
    
    void fadein()   //have bug!
    {
        if (logo is Graphic)
        {
            (logo as Graphic).CrossFadeAlpha(1, 0, true);
        }
        Invoke("fadeout", 2f);
    }

    void fadeout()
    {
        if (logo is Graphic)
        {
            (logo as Graphic).CrossFadeAlpha(0, 1, true);
        }
        Invoke("loadS", 1f);
    }

    void loadS()
    {
        SceneManager.LoadScene("title");
    }
}
