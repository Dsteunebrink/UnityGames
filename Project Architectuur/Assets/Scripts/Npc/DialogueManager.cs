using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public GameObject dText;
    public bool textChecker;

	// Use this for initialization
	void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void ShowBox() {

        dBox.SetActive(true);
        dText.SetActive(true);
    }

    public void RemoveBox() {

        dBox.SetActive(false);
        dText.SetActive(false);
    }

}