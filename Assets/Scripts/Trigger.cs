using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Trigger : MonoBehaviour
{
    public int pointValue;


    void OnTriggerEnter (Collider G) {
        if (G.tag == "Player") {
            Debug.Log (pointValue);
            PlayerPrefs.SetInt("Score", pointValue);
            Handheld.Vibrate();
            SceneManager.LoadScene("Score");
        }
    }
}
