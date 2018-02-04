using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationRight : MonoBehaviour {

    public GameObject entryPortal;
    public Transform exitPortal;

    private void OnTriggerEnter(Collider other)
    {
        bool leftIsBlocked = GameObject.Find("Left Portal Sensor").GetComponent<PortalSensorLeft>().leftIsBlocked;

        if (other.tag == "Player" && leftIsBlocked == false)
        {
            other.gameObject.transform.position = exitPortal.position;
            FindObjectOfType<AudioManager>().Play("PortalEntry");
        }
    }
}


