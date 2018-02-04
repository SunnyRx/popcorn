using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportationLeft : MonoBehaviour {

    public GameObject entryPortal;
    public Transform exitPortal;

    private void OnTriggerEnter(Collider other)
    {
        bool rightIsBlocked = GameObject.Find("Right Portal Sensor").GetComponent<PortalSensorRight>().rightIsBlocked;

        if (other.tag == "Player" && rightIsBlocked == false)
        {
            other.gameObject.transform.position = exitPortal.position;
            FindObjectOfType<AudioManager>().Play("PortalEntry");
        }
    }
}


