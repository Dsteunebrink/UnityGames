using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class pausescript : MonoBehaviour {

    public Transform canvas;
    public Transform Player;

    public string sceneName;

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

    public void restart() {
        Time.timeScale = 1;
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().name);
    }

    public void resume() {
        canvas.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    public void quit() {
        SceneManager.LoadSceneAsync("main_menu",LoadSceneMode.Single);
    }
}

