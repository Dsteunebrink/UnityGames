using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;

public class EndScript : MonoBehaviour {

    public Text scoreText;

    private gameMaster gameManager;
    private collector Player;

    [SerializeField] private GameObject GameScreen;
    [SerializeField] private GameObject EndScreen;

    // Use this for initialization
    void Start () {

        gameManager = GameObject.FindGameObjectWithTag ("gameMaster").GetComponent<gameMaster> ();
        Player = GameObject.FindGameObjectWithTag ("mainCollector").GetComponent<collector> ();
    }
	
	// Update is called once per frame
	void Update () {

        scoreText.text = ("You're Score Is " + gameManager.Score);

        IsDead ();
    }

    public void IsDead () {

        if (Player.health <= 0) {

            GameScreen.SetActive (false);
            EndScreen.SetActive (true);
            destroyAll ();
        }

    }

    public void mainMenuButton () {

        SceneManager.LoadSceneAsync ("main_menu", LoadSceneMode.Single);
    }

    public void replayButton() {

        SceneManager.LoadSceneAsync ("Game", LoadSceneMode.Single);
    }

    public void destroyAll () {
        Destroy (GameObject.FindGameObjectWithTag ("c"));
    }
}
