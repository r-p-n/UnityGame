using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SuccessfulEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup winBackgroundImageCanvasGroup;

    bool m_IsPlayerFree;
    float m_Timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerFree = true;
        }
    }

    void Update()
    {
        if (m_IsPlayerFree)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        m_Timer += Time.deltaTime;

        winBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;

        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            SceneManager.LoadScene("MainMenu");
        }

        if (m_Timer > fadeDuration + displayImageDuration)
        {
            Application.Quit();
        }
    }
}