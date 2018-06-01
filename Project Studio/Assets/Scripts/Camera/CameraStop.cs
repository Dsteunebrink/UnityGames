using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStop : MonoBehaviour {

    public bool StopCamera = false;

    public Transform target;

    void OnTriggerStay2D(Collider2D other) {

        if (other.gameObject.name == "Player" && StopCamera == false) {
            StopCamera = true;
        }
    }
}
