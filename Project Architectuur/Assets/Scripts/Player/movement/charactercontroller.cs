using UnityEngine;
using System.Collections;

public class charactercontroller : MonoBehaviour {

    public float speed = 10.0f;
    public float sprint = 20.0f;

    public Rigidbody rb;
    public bool IsGrounded;
    public Transform canvas;
    public Transform Player;
    private gameMaster gameManager;
    private DialogueManager dMan;


    void Start() {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
        Time.timeScale = 1;
        gameManager = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
        dMan = FindObjectOfType<DialogueManager>();
    }

    void Update() {

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;
        if (Input.GetButtonDown("Jump") && IsGrounded) {
            rb.velocity = new Vector3(0, 10, 0);
        }

        if (Input.GetKey(KeyCode.LeftShift)) {
            translation = Input.GetAxis("Vertical") * sprint;
            straffe = Input.GetAxis("Horizontal") * sprint;
        }

        transform.Translate(straffe, 0, translation);
    }


    void OnCollisionStay(Collision collisionInfo) {
        IsGrounded = true;
    }

    void OnCollisionExit(Collision collisionInfo) {
        IsGrounded = false;
    }

    void OnTriggerEnter(Collider col) {
        if (col.CompareTag("Tickets")) {
            Destroy(col.gameObject);
            gameManager.Points += 1;
        }
    }
}
