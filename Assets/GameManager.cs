using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverScreen;

    public TextMeshProUGUI scoreText;
    private int score;

    private void Update()
    {
        if (Input.GetKey("escape"))
        {
            Application.Quit();
        }
    }

    private void Start()
    {
        gameOverScreen.SetActive(false);
    }

    public void AddScore()
    {
        score++;
    }

    public void GameOver()
    {
        gameOverScreen.SetActive(true);
        scoreText.text = "SCORE: " + score.ToString();
        Time.timeScale = 0;
    }

    public void RestartGame()
    {
        Time.timeScale = 1;
        gameOverScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void LoadMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

}
