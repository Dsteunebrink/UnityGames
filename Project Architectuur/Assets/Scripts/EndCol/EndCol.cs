using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndCol : MonoBehaviour {

    private gameMaster gameManager;

    // Use this for initialization
    void Start () {
        gameManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider col) {
        if (col.CompareTag("Player") && gameManager.Points == 10) {
            Cursor.lockState = CursorLockMode.None;
            SceneManager.LoadSceneAsync("end_scene", LoadSceneMode.Single);
        }
    }
}
