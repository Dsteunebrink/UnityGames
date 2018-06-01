﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;




public class Portal : MonoBehaviour {

    private gameMaster gm;



    void Start() {
        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }


    void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            if (gm.points == 3) {
                SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
            }
        }
    }
}
