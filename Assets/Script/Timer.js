#pragma strict
import UnityEngine.SceneManagement;

var timer : float = 0;

function Update(){
	timer -= Time.deltaTime;

	if(timer <= 0){
		timer = 0;
	}
}

function OnGUI(){
	if(timer > 0){
		GUI.Box(new Rect(715, 50, 190, 25), "Time Remaining : " + timer.ToString("0"));
	} else {
		gameOver();
	}

}

function gameOver(){
	GUI.Box(new Rect(715, 50, 190, 25), "Game Over");
	SceneManager.LoadScene("ResultScene");
}