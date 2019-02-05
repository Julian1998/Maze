using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trigger : MonoBehaviour
{
    public int pointValue;


    void OnTriggerEnter (Collider G) {
        if (G.tag == "Player") {
            Debug.Log (pointValue);
            PlayerPrefs.SetInt("Score", pointValue);
            Application.LoadLevelAdditive(1);
            Handheld.Vibrate();
        }
    }
}
