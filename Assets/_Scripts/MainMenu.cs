using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        Debug.Log("Start");
        SceneManager.LoadScene("Harper");
    }

    public void EndGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

}
