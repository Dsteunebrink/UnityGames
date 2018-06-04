using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scoreCollision : MonoBehaviour {

    public bool checkCol;

    public int setActiveTimer = 50;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (checkCol == true) {

            setActiveTimer--;
            if (setActiveTimer <= 0) {
                checkCol = false;
                setActiveTimer = 10;
            }
        }
    }

    public void OnTriggerStay (Collider col)
    {
        if (col.CompareTag("c")) {

            checkCol = true;
        }
    }
}
