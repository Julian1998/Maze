using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScoreCounter : MonoBehaviour {
	
        public Text scoreText;
        public int points;
        public int highscore;

        // Update is called once per frame
        void Start () {
            scoreText = scoreText.GetComponent<Text> ();
            
            points = PlayerPrefs.GetInt("Score", 0);
            highscore = PlayerPrefs.GetInt("Highscore", 0);
            if(points >= highscore)
            {
                PlayerPrefs.SetInt("Highscore", points);
                scoreText.text = "New Highscore: " + points;
            }
            else
            {
                scoreText.text = "Score: " + points;
            }
            
        }

        public void LoadMenu()
        {
            SceneManager.LoadScene("Menu");
        }
    }


