using UnityEngine;
using System.Collections;

public class DialogueRemove : MonoBehaviour {

    private DialogueManager dMan;
    public GameObject dText;
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
            dText.SetActive(false);
        }
    }
}
