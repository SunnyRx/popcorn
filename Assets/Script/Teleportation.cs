using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

    public GameObject entryPortal;
    public Transform exitPortal;

    private bool playerIsOverLapping = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            playerIsOverLapping = true;
            other.gameObject.transform.position = exitPortal.position;
            FindObjectOfType<AudioManager>().Play("PortalEntry");
        }
    }
}


