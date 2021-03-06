﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WordBorder : MonoBehaviour {

    void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Player")) {
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
        }
    }
}
