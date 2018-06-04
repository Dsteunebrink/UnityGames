using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collector : MonoBehaviour {

    [SerializeField] private GameObject collector_1;
    [SerializeField] private GameObject collector_2;
    [SerializeField] private GameObject collector_3;
    [SerializeField] private GameObject collector_4;

    public Transform start_direction;
    public int pace = 9;

    public bool checkCube;
    public int setActiveTimer = 1;

    public int timer1 = 10;
    public int timer2 = 10;
    public int timer3 = 10;
    public int timer4 = 10;

    public bool collector1;
    public bool collector2;
    public bool collector3;
    public bool collector4;

    public int health;
    public Text healthText;

    public int Timer = 10000;

    public scoreCollision Collision;

    

    // Use this for initialization
    void Start () {

        Collision = GameObject.FindGameObjectWithTag ("Cube").GetComponent<scoreCollision> ();

        transform.LookAt(start_direction);

        health = 5;
    }
	
	// Update is called once per frame
	void Update () {

        transform.position += transform.forward * pace * Time.deltaTime;

        healthText.text = ("Lives: " + health);

        OnClick ();

        if(Timer >= 0) {
            Timer--;
        }else if (Timer <= 0) {
            pace = 11;
        }

        if (checkCube == true)
        {

            setActiveTimer--;
            if (setActiveTimer <= 0)
            {
                checkCube = false;
                setActiveTimer = 50;
            }
        }

        if (collector1 == true) {
            collector_1.SetActive (true);
            timer1--;
            if(timer1 <= 0) {
                collector_1.SetActive (false);
                collector1 = false;
                timer1 = 10;
            }
        }

        if (collector2 == true) {
            collector_2.SetActive (true);
            timer2--;
            if (timer2 <= 0) {
                collector_2.SetActive (false);
                collector2 = false;
                timer2 = 10;
            }
        }

        if (collector3) {
            collector_3.SetActive (true);
            timer3--;
            if (timer3 <= 0) {
                collector_3.SetActive (false);
                collector3 = false;
                timer3 = 10;
            }
        }

        if (collector4) {
            collector_4.SetActive (true);
            timer4--;
            if (timer4 <= 0) {
                collector_4.SetActive (false);
                collector4 = false;
                timer4 = 10;
            }
        }
    }

    private void OnClick() {

        if (Input.GetKeyDown(KeyCode.Q)) {
            collector1 = true;
            checkCube = true;
            if (Collision.checkCol == false) {
                Damage (1);
            }
        }

        if (Input.GetKeyDown(KeyCode.W)) {
            collector2 = true;
            checkCube = true;
            if (Collision.checkCol == false) {
                Damage (1);
            }
        }

        if (Input.GetKeyDown(KeyCode.E)) {
            collector3 = true;
            checkCube = true;
            if (Collision.checkCol == false) {
                Damage (1);
            }
        }

        if (Input.GetKeyDown(KeyCode.R)) {
            collector4 = true;
            checkCube = true;
            if (Collision.checkCol == false) {
                Damage (1);
            }
        }
    }

    public void Damage(int a){

        health -= a;
    }
}
