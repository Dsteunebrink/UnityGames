using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menuctrl : MonoBehaviour {

    public Transform canvas;
    public GameObject mainMenu;
    public GameObject optionsMenu;
    public GameObject player;
    public GameObject menuCamera;
    public GameObject counter;
    public GameObject dialogue;

    public Slider[] volumeSliders;
    public Toggle[] resolutionToggles;
    public Toggle fullscreenToggle;
    public int[] screenWidths;
    int activeScreenResIndex;

    void Start() {
        activeScreenResIndex = PlayerPrefs.GetInt("screen res index");
        bool isFullscreen = (PlayerPrefs.GetInt("fullscreen") == 1) ? true : false;

        for (int i = 0; i < resolutionToggles.Length; i++) {
            resolutionToggles[i].isOn = i == activeScreenResIndex;
        }

        fullscreenToggle.isOn = isFullscreen;
    }
    public void StartGame() {
        if (mainMenu.activeInHierarchy == true) {
            mainMenu.SetActive(false);
            menuCamera.SetActive(false);
            player.SetActive(true);
            counter.SetActive(true);
            dialogue.SetActive(true);
            Cursor.lockState = CursorLockMode.Locked;
        }
    }

    public void StopGame() {
        Application.Quit();
    }

    public void Opties() {
        if (mainMenu.activeInHierarchy == false) {
            mainMenu.SetActive(true);
            optionsMenu.SetActive(false);
        } else if (mainMenu.activeInHierarchy == true) {
            mainMenu.SetActive(false);
            optionsMenu.SetActive(true);
        }
    }

    public void SetScreenResolution(int i) {
        if (resolutionToggles[i].isOn) {
            activeScreenResIndex = i;
            float aspectRatio = 16 / 9f;
            Screen.SetResolution(screenWidths[i], (int)(screenWidths[i] / aspectRatio), false);
            PlayerPrefs.SetInt("screen res index", activeScreenResIndex);
            PlayerPrefs.Save();
        }
    }

    public void SetFullscreen(bool isFullscreen) {
        for (int i = 0; i < resolutionToggles.Length; i++) {
            resolutionToggles[i].interactable = !isFullscreen;
        }

        if (isFullscreen) {
            Resolution[] allResolutions = Screen.resolutions;
            Resolution maxResolution = allResolutions[allResolutions.Length - 1];
            Screen.SetResolution(maxResolution.width, maxResolution.height, true);
        } else {
            SetScreenResolution(activeScreenResIndex);
        }

        PlayerPrefs.SetInt("fullscreen", ((isFullscreen) ? 1 : 0));
        PlayerPrefs.Save();
    }
}



