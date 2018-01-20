using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelCompleteMulti: MonoBehaviour {

    public void LoadNextLevelMulti()
    {
        SceneManager.LoadScene("ResultSceneMulti");
    }
}
