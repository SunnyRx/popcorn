using UnityEngine.SceneManagement;
using UnityEngine;

public class CountdownTimer : MonoBehaviour {
    float timeRemaing = 60;

	// Use this for initialization
	void Start () {

    }

    // Update is called once per frame
    void Update () {
        timeRemaing -= Time.deltaTime;
	}

    private GUIStyle guiStyle = new GUIStyle(); //create a new variable

    private void OnGUI()
    {
        guiStyle.fontSize = 25; //change the font size

        if (timeRemaing > 0)
        {
            GUI.Label(new Rect(1100, 100, 200, 200), "Time Remaining : " + (int)timeRemaing, guiStyle);
        }
        else
        {
            GUI.Label(new Rect(100, 100, 200, 100), "Time's up");
            SceneManager.LoadScene("ResultScene");
        }

    }
}
