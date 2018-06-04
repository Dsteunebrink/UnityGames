using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {

    public GameObject cube;
    public GameObject cube2;
    private float spawnTime = 2f;
    private float spawnTime2 = 2f;
    private bool spawnTimeActive;
    private bool spawnTime2Active;
    public Transform[] spawnPoints;
    public Transform[] spawnPoints2;
    private int enemyCount = 0;
    public float diff = 30f;
    public float delaytime = 2f;



    void Start()
    {
        spawnTimeActive = true;
        spawnTime2Active = false;
    }

    private void Update()
    {
        if (spawnTimeActive == true) {
            spawnTime -= Time.deltaTime;
        } else if (spawnTime2Active == true) {
            spawnTime2 -= Time.deltaTime;
        }

        diff -= Time.deltaTime;

        if (diff <= 0)
        {
            diff = 20f;
            delaytime -= 0.2f;

            if (delaytime <= 0)
            {
                delaytime = 0.2f;
            }
        }

        if (spawnTime <= 0){
            int spawnPointIndex = Random.Range(0, spawnPoints.Length);
            GameObject enemyC = Instantiate(cube, spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
            enemyCount++;
            spawnTime2 = delaytime;
            spawnTime = delaytime;

            spawnTimeActive = false;
            spawnTime2Active = true;

            cube.GetComponent<collectable>().SetsTime(-0.1f);
        }

        if (spawnTime2 <= 0) {
            int spawnPointIndex2 = Random.Range (0, spawnPoints2.Length);
            GameObject enemyC2 = Instantiate (cube2, spawnPoints2[spawnPointIndex2].position, spawnPoints2[spawnPointIndex2].rotation);
            enemyCount++;
            spawnTime = delaytime;
            spawnTime2 = delaytime;

            spawnTimeActive = true;
            spawnTime2Active = false;

            cube2.GetComponent<collectable> ().SetsTime (-0.1f);
        }

    }
}
