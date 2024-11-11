using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public GameObject menuScreen;

    public void PlayButton()
    {
        menuScreen.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene("PlayingScene");
    }
}
