using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public bool MoveCamera = false;

    CameraStop cameraStop;

    public Transform target;

    void Start() {
        cameraStop = GameObject.FindGameObjectWithTag("CameraStop").GetComponent<CameraStop>();
    }
    void OnTriggerStay2D(Collider2D other) {

        if (other.gameObject.name == "Player" && MoveCamera == false) {
            cameraStop.StopCamera = false;
            MoveCamera = true;
        }
    }
}
