using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class pause_Menu : MonoBehaviour {

    public Transform canvas;
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject player;
    public GameObject menuCamera;
    public GameObject counter;
    public GameObject dialogue;
    public GameObject mainCamara;
    public GameObject pauseMenu;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pause();
        }
    }

    public void Pause() {
        if (pauseMenu.activeInHierarchy == false) {
            pauseMenu.SetActive(true);
            mainCamara.GetComponent<camMouseLook>().enabled = false;
            Time.timeScale = 0;
            Cursor.lockState = CursorLockMode.None;
        } else {
            pauseMenu.SetActive(false);
            Cursor.lockState = CursorLockMode.Locked;
            mainCamara.GetComponent<camMouseLook>().enabled = true;
            Time.timeScale = 1;
            
        }
    }

    public void Resume() {
        pauseMenu.SetActive(false);
        Time.timeScale = 1;
        mainCamara.GetComponent<camMouseLook>().enabled = true;
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void Stop() {
        SceneManager.LoadSceneAsync("Game", LoadSceneMode.Single);
    }
}

