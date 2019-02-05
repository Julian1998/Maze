using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{

    public Text highscoreText;

    void Start()
    {
        highscoreText = highscoreText.GetComponent<Text>();
        int highscore = PlayerPrefs.GetInt("Highscore", 0);
        highscoreText.text = "Highscore: " + highscore;
    }
    
    public void PlayGame()
    {
        SceneManager.LoadScene("Maze");
    }
    
    public void QuitGame()
    {
        Application.Quit();
    }
}
