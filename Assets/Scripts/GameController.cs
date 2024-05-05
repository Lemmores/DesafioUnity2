using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public int totalScore;
    public TextMeshProUGUI scoreText; 

    public GameObject gameOver;
    public GameObject pause;
    public static GameController instance;

    // Start is called before the first frame update
    void Start()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            ShowPause(true);
        }
       
    }
    public void UpdateScoreText()
    {
        scoreText.text = totalScore.ToString();
    } 

    public void ShowGameOver()
    {
        gameOver.SetActive(true);
    }

    public void RestartGame(string lvlName)
    {
        SceneManager.LoadScene(lvlName);
    }

    public void ShowPause(bool value)
    {
        pause.SetActive(value);
        Time.timeScale=value?0:1;
    }


}
