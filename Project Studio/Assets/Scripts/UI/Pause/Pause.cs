using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Pause : MonoBehaviour {
    public Transform canvas;
    public Transform Player;

    public Button restartbutton;
    public Button resumbutton;
    public Button quitbutton;

    public string sceneName;

        void Start() {
        restartbutton.onClick.AddListener(LoadScene);
        resumbutton.onClick.AddListener(Resume);
        quitbutton.onClick.AddListener(Quit);
    }

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Pause_game();
        }
    }
    public void Pause_game() {
        if (canvas.gameObject.activeInHierarchy == false) {
            canvas.gameObject.SetActive(true);
            Time.timeScale = 0;

        } else {
            canvas.gameObject.SetActive(false);
            Time.timeScale = 1;
        }
    }

    public void LoadScene() {
        Time.timeScale = 1;
        SceneManager.LoadScene(sceneName);
    }


public void Resume() {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void Quit() {
        //Application.Quit();
    }
}
