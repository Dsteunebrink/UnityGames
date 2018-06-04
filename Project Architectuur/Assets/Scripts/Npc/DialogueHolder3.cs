using UnityEngine;
using System.Collections;

public class DialogueHolder3 : MonoBehaviour {

    private DialogueManager dMan;
    public GameObject dText;
    public string dialogue;
    public bool textChecker;

    // Use this for initialization
    void Start() {
        dMan = FindObjectOfType<DialogueManager>();
    }

    // Update is called once per frame
    void Update() {
    }

    void OnTriggerEnter(Collider col) {

        if (col.CompareTag("Player")) {
            dText.SetActive(true);
        }
    }
}
