using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class collision : MonoBehaviour {

    private gameMaster gameManager;

    void Start() {
        gameManager = GameObject.FindGameObjectWithTag("gameMaster").GetComponent<gameMaster>();
    }

    void Update() {
    }

    void OnTriggerEnter(Collider col) {
        if (col.CompareTag("c")) {
            Destroy(col.gameObject);
            gameManager.Multiplier += 0.1f;

            gameManager.tempPoints = (int)(gameManager.Points * gameManager.Multiplier);

            gameManager.Score += gameManager.tempPoints;
            gameManager.tempPoints = 0;
        }
    }
}

