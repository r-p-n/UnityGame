using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockedDoors : MonoBehaviour
{
    public float fadeDuration = 1f;
    public float displayImageDuration = 1f;
    public GameObject player;
    public CanvasGroup blockedTextCanvasGroup;


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == player)
        {
            blockedTextCanvasGroup.alpha = 1;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
        {
            blockedTextCanvasGroup.alpha = 0;
        }
    }
}

