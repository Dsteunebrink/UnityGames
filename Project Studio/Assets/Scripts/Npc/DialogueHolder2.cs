using UnityEngine;
using System.Collections;

public class DialogueHolder2 : MonoBehaviour {

    public string dialogue;
    private DialogueManager dMan;
    public bool textChecker;

    // Use this for initialization
    void Start() {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerStay2D(Collider2D other) {

        if (other.gameObject.name == "Player") {
            dMan.RemoveBox(dialogue);
            textChecker = true;
        }
    }
}
