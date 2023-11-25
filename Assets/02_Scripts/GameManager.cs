using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public int currentLevelIndex;
    void Start()
    {
        
    }

    void Update()
    {

    }

    public void LoadNextLevel()
    {
        currentLevelIndex += 1;
        SceneManager.LoadScene(currentLevelIndex);
    }

    public void GameOverScene()
    {

    }

    public void StartScene()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }

    public void GoToMainMenu()
    {
        if(Time.timeScale == 0) Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

}
