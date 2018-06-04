using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn_platform : MonoBehaviour {

    public Transform plane1;
    public Transform plane2;

    public bool plat_switch;
    public bool plat_check;


    // Use this for initialization
    void Start () {

        plat_switch = true;
        plat_check = true;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col) {
        if (col.CompareTag("trigger") && plat_switch == true && plat_check == true) {
            plane1.localPosition = new Vector3(plane1.localPosition.x, plane1.localPosition.y, plane1.localPosition.z + 67.24f);
            plat_switch = false;
            plat_check = false;
        }
        if (col.CompareTag("trigger") && plat_switch == false && plat_check == true) {
            plane2.localPosition = new Vector3(plane2.localPosition.x, plane2.localPosition.y, plane2.localPosition.z + 67.24f);
            plat_switch = true;
            plat_check = false;
        }
        if (col.CompareTag("trigger_start") && plat_check == false) {
            plat_check = true;
        }
    }
}
