using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalSensorRight : MonoBehaviour {

    public bool rightIsBlocked;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            rightIsBlocked = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        rightIsBlocked = false;
    }
}
