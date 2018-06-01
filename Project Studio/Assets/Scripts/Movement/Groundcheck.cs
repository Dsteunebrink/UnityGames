using UnityEngine;
using System.Collections;

public class Groundcheck : MonoBehaviour {

    private PlayerController PC;

    Animator anim;

    bool grounded = false;
    public Transform groundCheck;
    float groundCheckRadius = 10f;
    public float jumpForce = 700f;
    public LayerMask whatIsGround;

    void Start () {
        PC = GetComponent<PlayerController>();
    }

    void FixedUpdate() {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, whatIsGround);
        anim.SetBool("Ground", grounded);
    }


    void Update() {
        if (grounded) {
            anim.SetBool("Ground", false);
            GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    }
}

