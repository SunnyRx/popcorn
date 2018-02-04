using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSensorLeft : MonoBehaviour {

    public bool leftIsBlocked;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            leftIsBlocked = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        leftIsBlocked = false;
    }
}
