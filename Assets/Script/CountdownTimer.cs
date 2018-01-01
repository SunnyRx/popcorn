using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {
    public Text timerText;

    float timeRemaining = 60;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        timeRemaining -= Time.deltaTime;
	}

    private GUIStyle guiStyle = new GUIStyle(); //create a new variable

    private void OnGUI()
    {
        guiStyle.fontSize = 25; //change the font size

        if (timeRemaining > 0)
        {
            timerText.text = "Time Remaining: " + (int)timeRemaining;
        }
        else
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time's up");
            SceneManager.LoadScene("ResultScene");
        }

    }
}
