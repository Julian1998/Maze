using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Trigger : MonoBehaviour
{
    public int pointValue;
    
    void OnTriggerEnter (Collider G) {
        if (G.tag == "Player") {
            ScoreCounter.Scorer += pointValue;
            Debug.Log (ScoreCounter.Scorer);
            
        }
    }
}

