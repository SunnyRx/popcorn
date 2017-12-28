using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

    public AudioSource mainAudioSource;

    static SoundManager _instance;

    

    static public SoundManager getInstance()
    {
        if (!_instance)
        {
            _instance = new SoundManager();
        }
        return _instance;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void playSound(AudioClip clip)
    {
        mainAudioSource.clip = clip;
        mainAudioSource.Play();
    }   

}