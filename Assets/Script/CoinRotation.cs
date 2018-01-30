using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinRotation : MonoBehaviour {

    // Rotates the object to which it is attached.
    void Update()
    {
        float xRotation = Random.Range(0.0f, 15.0f);
        float yRotation = Random.Range(0.0f, 5.0f);
        transform.Rotate(Time.deltaTime, xRotation, yRotation);
    }
}
