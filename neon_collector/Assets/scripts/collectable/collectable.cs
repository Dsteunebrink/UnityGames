using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour {

    private gameMaster gameManager;
    public static float sTime = 2f;

    // Use this for initialization
    void Start () {

        gameManager = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<gameMaster>();
    }
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter(Collider col) {
        if (col.CompareTag("missCol")) {
            Destroy(this.gameObject);
            gameManager.Multiplier = 1.0f;
        }
    }

    public void SetsTime(float s)
    {
        sTime += s;
    }

    public void killAll () {
        Destroy (this.gameObject);
    }
}
