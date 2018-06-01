using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    public Transform target;

    Vector3 velocity = Vector3.zero;

    public float smoothTime = .15f;
    //enable and set the max Y value
    public bool YMaxEnabled = false;
    public float YMaxValue = 0;

    //enable and set the min Y value
    public bool YMinEnabled = false;
    public float YMinValue = 0;

    CameraStop cameraStop;
    CameraMove cameraMove;

    void Start() {
        cameraStop = GameObject.FindGameObjectWithTag("CameraStop").GetComponent<CameraStop>();
        cameraMove = GameObject.FindGameObjectWithTag("CameraMove").GetComponent<CameraMove>();
    }

    public void FixedUpdate() {

        Vector3 targetPos = target.position;

        //vertical
        if (YMinEnabled && YMaxEnabled) {
            targetPos.y = Mathf.Clamp(target.position.y, YMaxValue, YMinValue);
        } else if (YMinEnabled) {
            targetPos.y = Mathf.Clamp(target.position.y, YMinValue, target.position.y);
        } else if (YMaxEnabled) {
            targetPos.y = Mathf.Clamp(target.position.y, target.position.y, YMaxValue);
        }
        if (cameraStop.StopCamera == true) {

            targetPos.z = transform.position.z;
            transform.position = Vector3.SmoothDamp(transform.position, targetPos, ref velocity, smoothTime);
            cameraMove.MoveCamera = false;
        }

        if (cameraMove.MoveCamera == true) {
            cameraStop.StopCamera = false;
        }
    }
}
