using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class gameMaster : MonoBehaviour {


    public int points;
    public Text PointsText;

    void Update() {

        PointsText.text = ("Sleutels: " + points);

    }
}