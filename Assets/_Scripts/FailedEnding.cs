using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailedEnding : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup failedBackgroundImageCanvasGroup;

    bool m_IsPlayerDead;
    float m_Timer;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            m_IsPlayerDead = true;
        }
    }

    void Update()
    {
        if (m_IsPlayerDead)
        {
            GameOver();
        }
    }

    void GameOver()
    {
        m_Timer += Time.deltaTime;

        failedBackgroundImageCanvasGroup.alpha = m_Timer / fadeDuration;


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