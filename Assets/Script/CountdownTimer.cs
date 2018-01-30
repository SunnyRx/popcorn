using UnityEngine;
using UnityEngine.UI;

public class CountdownTimer : MonoBehaviour {
    public Text timerText;
    public bool timerIsPaused = false;
    public float timeRemaining = 60;

    public GameObject levelTransitionUI;

	// Use this for initialization
	void Start () {
        GameObject.Find("GameSystem").GetComponent<GameSystem>().score = 0;
    }

    // Update is called once per frame
    void Update () {
        if (!timerIsPaused)
        {
            timeRemaining -= Time.deltaTime;
        }
    }

    private GUIStyle guiStyle = new GUIStyle(); //create a new variable

    private void OnGUI()
    {
        guiStyle.fontSize = 25; //change the font size

        if (timeRemaining > 0)
        {
            timerText.text = "残り時間 : " + (int)timeRemaining;
        }
        else
        {
            levelTransitionUI.SetActive(true);
        }

    }
}
