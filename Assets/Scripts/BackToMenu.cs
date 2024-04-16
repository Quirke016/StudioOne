using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackToMenu : MonoBehaviour
{
    public StatsManeager sM;
    public void ToMenu()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainMenu");
    }

    public void StartGame()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("MainScene");
    }

}
