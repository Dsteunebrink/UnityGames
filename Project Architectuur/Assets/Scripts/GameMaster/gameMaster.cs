using UnityEngine;
using UnityEngine.UI;

using System.Collections;

public class gameMaster : MonoBehaviour {


    public int Points;
    public Text PointsText;

    void Update() {

        PointsText.text = ("Tickets: " + Points + "/10");

    }
}
