using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    void OnTriggerEnter (Collider G) {
        if (G.tag == "Player") {
            ScoreCounter.Scorer += 10;
            Debug.Log (ScoreCounter.Scorer);
            
        }
    }
}

