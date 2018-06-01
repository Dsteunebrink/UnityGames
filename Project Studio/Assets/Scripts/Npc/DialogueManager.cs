using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

    public GameObject dBox;
    public Text dText;

    public bool dialogueActive;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

	    if(dialogueActive && Input.GetKeyDown(KeyCode.E)) {

            dBox.SetActive(false);
            dialogueActive = false;
        }
	}

    public void ShowBox(string dialogue) {

        dialogueActive = true;
        dBox.SetActive(true);
        dText.text = dialogue;
    }

    public void RemoveBox(string dialogue) {

        dialogueActive = false;
        dBox.SetActive(false);
        dText.text = dialogue;
    }

}