using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PickUps : MonoBehaviour
{
    [SerializeField]
    public GameObject PickupPicture;
    public GameObject Door;
    private float speed = 50.0f;
    public AudioSource audioSource;

    private void Start()
    {
        audioSource = GetComponent <AudioSource> ();
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.tag == "Player")
        {
            //Determine which Pick up it is

            //Diplay in top right corner
            PickupPicture.SetActive(true);
            //Delete the game object
            Destroy(this.gameObject);
            //Open one of the doors
            Destroy(Door);
            audioSource.Play();
            
        }
    }

    private void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * speed * Time.deltaTime);
    }

}
