using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ModeSelect : MonoBehaviour {

	public void SelectMode(int mode)
	{
		GameManager.Instance.playMode = mode;
		SceneManager.LoadScene("main");
	}

}
