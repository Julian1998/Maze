using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	
        public Text scoreText;
        public static int Scorer;


        void Start(){
            scoreText = GetComponent<Text> ();
        }

        // Update is called once per frame
        void Update () {
            scoreText.text = "Score: " + Scorer;
        }
    }


