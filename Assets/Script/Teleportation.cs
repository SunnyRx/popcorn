using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour {

    public GameObject entryPortal;
    public Transform exitPortal;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            other.gameObject.transform.position = exitPortal.position;
            FindObjectOfType<AudioManager>().Play("PortalEntry");
        }
    }
}


