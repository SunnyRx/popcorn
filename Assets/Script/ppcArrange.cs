using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ppcArrange : MonoBehaviour {

    public int arrangeCount=10;

	public List<List<Vector3>> arrange;

	public ppcArrange()
	{
		arrange = new List<List<Vector3>>();

		List<Vector3> tempList = new List<Vector3> ();

		//Shit1
		{
            tempList.Add (new Vector3(1,3,214));
			tempList.Add (new Vector3(2,-3,214));
			tempList.Add (new Vector3(1,3,212));
			tempList.Add (new Vector3(2,-3,212));
			tempList.Add (new Vector3(1,3,210));
			tempList.Add (new Vector3(2,-3,210));
			tempList.Add (new Vector3(1,3,208));
			tempList.Add (new Vector3(2,-3,208));
			tempList.Add (new Vector3(1,3,206));
			tempList.Add (new Vector3(2,-3,206));

			tempList.Add (new Vector3(2,3,200));
			tempList.Add (new Vector3(1,-3,200));
			tempList.Add (new Vector3(2,3,108));
			tempList.Add (new Vector3(1,-3,108));
			tempList.Add (new Vector3(2,3,106));
			tempList.Add (new Vector3(1,-3,106));
			tempList.Add (new Vector3(2,3,104));
			tempList.Add (new Vector3(1,-3,104));
			tempList.Add (new Vector3(2,3,102));
			tempList.Add (new Vector3(1,-3,100));


			tempList.Add (new Vector3(1,7,90));
			tempList.Add (new Vector3(2,-7,90));
			tempList.Add (new Vector3(1,7,88));
			tempList.Add (new Vector3(2,-7,88));
			tempList.Add (new Vector3(1,7,86));
			tempList.Add (new Vector3(2,-7,86));
			tempList.Add (new Vector3(1,7,84));
			tempList.Add (new Vector3(2,-7,84));
			tempList.Add (new Vector3(1,7,82));
			tempList.Add (new Vector3(2,-7,82));

			tempList.Add (new Vector3(2,7,70));
			tempList.Add (new Vector3(1,-7,70));
			tempList.Add (new Vector3(2,7,68));
			tempList.Add (new Vector3(1,-7,68));
			tempList.Add (new Vector3(2,7,66));
			tempList.Add (new Vector3(1,-7,66));
			tempList.Add (new Vector3(2,7,64));
			tempList.Add (new Vector3(1,-7,64));
			tempList.Add (new Vector3(2,7,62));
			tempList.Add (new Vector3(1,-7,62));

			tempList.Add (new Vector3(1,7,50));
			tempList.Add (new Vector3(2,-7,50));
			tempList.Add (new Vector3(1,7,48));
			tempList.Add (new Vector3(2,-7,48));
			tempList.Add (new Vector3(1,7,46));
			tempList.Add (new Vector3(2,-7,46));
			tempList.Add (new Vector3(1,7,44));
			tempList.Add (new Vector3(2,-7,44));
			tempList.Add (new Vector3(1,7,42));
			tempList.Add (new Vector3(2,-7,42));

			tempList.Add (new Vector3(2,7,30));
			tempList.Add (new Vector3(1,-7,30));
			tempList.Add (new Vector3(2,7,28));
			tempList.Add (new Vector3(1,-7,28));
			tempList.Add (new Vector3(2,7,26));
			tempList.Add (new Vector3(1,-7,26));
			tempList.Add (new Vector3(2,7,24));
			tempList.Add (new Vector3(1,-7,24));
			tempList.Add (new Vector3(2,7,22));
			tempList.Add (new Vector3(1,-7,22));

		}
        arrange.Add(tempList);

    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
