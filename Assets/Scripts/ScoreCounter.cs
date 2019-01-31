using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour {
	
        public Text scoreText;
        public int points;
        private int highscore;


        void Start(){
            scoreText = GetComponent<Text> ();
        }

        // Update is called once per frame
        void Update () {
            points = PlayerPrefs.GetInt("Score");
            highscore = PlayerPrefs.GetInt("Highscore");
            if(points > highscore)
            {
                PlayerPrefs.SetInt("Highscore", points);
                scoreText.text = "New Highscore: " + points;
            }
            else
            {
                scoreText.text = "Score: " + points;
            }
            
        }
    }


