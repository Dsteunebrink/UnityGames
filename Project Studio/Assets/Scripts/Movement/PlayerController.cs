using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

    public float maxSpeed = 10f;
    bool facingRight = true;

    Animator anim;

    bool grounded = false;
    public Transform groundCheck;
    float groundRadius = 0.2f;
    public LayerMask whatIsGround;
    public float jumpForce =1000f;
    private gameMaster gm;
    float move; 



    void Start() {
        anim = GetComponent<Animator>();

        gm = GameObject.FindGameObjectWithTag("GameMaster").GetComponent<gameMaster>();
    }

    public void FixedUpdate() {
        grounded = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);

       float move = Input.GetAxis("Horizontal");

        anim.SetBool("Ground", grounded);

        if (move > 0 && !facingRight)
            Flip();
        else if (move < 0 && facingRight)
            Flip();

        anim.SetFloat("vSpeed", GetComponent<Rigidbody2D>().velocity.y);
        anim.SetFloat("Speed", Mathf.Abs(move));
        GetComponent<Rigidbody2D>().velocity = new Vector2(move * maxSpeed, GetComponent<Rigidbody2D>().velocity.y);
    }


    void Update() {
        if (grounded && Input.GetKeyDown(KeyCode.Space)) {
                anim.SetBool("Ground", false);
               GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
            }
        }


        void Flip() {
        facingRight = !facingRight;
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }


    void OnTriggerEnter2D(Collider2D col) {
        if (col.CompareTag("Sleutel")) {
            Destroy(col.gameObject);
            gm.points += 1;
        }
    }


    public void RightMovement() {
       move = 1;
    }

    public void LeftMovement() {
       move = -1;
    }

    public void StopMovement() {
      move = 0;
    }

    public void Jump() {

        if (grounded) {
            anim.SetBool("Ground", false);
           GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpForce));
        }
    }
}

