using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
   public void Reset()
    {
        SceneManager.LoadScene("Level");
        ScoreScript.scoreValue = 0f;
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    public void QuitGame()
    {
        Debug.Log("Quit Successful!");
        Application.Quit();
    }
}
