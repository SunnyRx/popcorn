using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppc : MonoBehaviour {

    public int Score;
    public float force;
    public int playerNum;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public int TakePopcorn()
    {
        //Debug.Log("Got it!");
        return Score;
    }
}
