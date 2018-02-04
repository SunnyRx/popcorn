using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class props : MonoBehaviour {

	public enum propType
	{
		getMore
	}

	public propType type;

	public float force;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	string getName()
	{
		return name;
	}

	public void TakePopcorn()
	{
		switch (type)
		{
		case propType.getMore:
			ppcManager.getInstance().setCurrentGameMode(ppcManager.gameMode.getMore);
			break;
		}

	}
	void OnTriggerEnter(Collider other)
	{
		switch (other.tag)
		{
		case "Floor":
			Destroy(this.gameObject);
			break;

        case "Stage":
            Destroy(this.gameObject);
            break;
        }
    }
}
