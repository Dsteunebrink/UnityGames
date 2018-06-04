using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sun_moon : MonoBehaviour {
    public float Time;
    public Light lt; 
    // Use this for initialization

    void Start () {
        lt = GetComponent<Light>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        transform.RotateAround(Vector3.zero, Vector3.right, Time);
        transform.LookAt(Vector3.zero);

        if (transform.rotation.x < 10)
        {
            lt.intensity = 0.9f;
        }
        if (transform.rotation.x < 9)
        {
            lt.intensity = 0.8f;
        }
        if (transform.rotation.x < 8)
        {
            lt.intensity = 0.7f;
        }
        if (transform.rotation.x < 7)
        {
            lt.intensity = 0.6f;
        }
        //if (transform.rotation.x < 6)
        //{
          //  lt.intensity = 0f;
       // }

    }
}
