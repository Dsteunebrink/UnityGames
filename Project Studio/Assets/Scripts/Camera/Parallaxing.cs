using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallaxing : MonoBehaviour {

    public Transform[] backgrounds;
    public float[] parallaxScales;
    public float Smoothing;

    private Vector3 PreviousCameraPosition;




    // Use this for initialization
    void Start() {

        PreviousCameraPosition = transform.position;

        parallaxScales = new float[backgrounds.Length];

        for (int i = 0; i < parallaxScales.Length; i++) {
            parallaxScales[i] = backgrounds[i].position.z * -1;

        }

    }

    // Update is called once per frame
    void LateUpdate() {

        for (int i = 0; i < backgrounds.Length; i++) {
            Vector3 parallax = (PreviousCameraPosition - transform.position) * (parallaxScales[i] / Smoothing);

            backgrounds[i].position = new Vector3(backgrounds[i].position.x + parallax.x, backgrounds[i].position.y, backgrounds[i].position.z);
        }

        PreviousCameraPosition = transform.position;

    }
}