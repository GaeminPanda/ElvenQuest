using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public string Scenechange;
   public void PlayGame ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void OnCredits()
    {
        SceneManager.LoadScene(Scenechange);
    }

    public void QuitGame ()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void ReturnMainMenu()
    {
        SceneManager.LoadScene(Scenechange);
    }

}
