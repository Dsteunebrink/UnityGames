using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
public class Menuctrl : MonoBehaviour {
 
    public void LoadScene(string sceneName) {

        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Stop() {
        SceneManager.LoadSceneAsync("main_menu", LoadSceneMode.Single);
    }

    public void StopGame() {
        Application.Quit();
    }


}
