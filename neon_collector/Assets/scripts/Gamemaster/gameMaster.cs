using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class gameMaster : MonoBehaviour {


    public int Points;
    public int tempPoints;
    public float Multiplier = 1f;
    public int Score;
    public Text MultiplierText;
    public Text ScoreText;

    private void Start()
    {
        Points = 25;
    }

    void Update() {

        ScoreText.text = ("Points: " + Score);
        MultiplierText.text = ("Multiplier: " + Multiplier);
    }
}
