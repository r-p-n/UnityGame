using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpider : MonoBehaviour
{
    [SerializeField]
    GameObject spider;

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            spider.SetActive(true);
        }
    }
}
