using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideMusic : MonoBehaviour
{
    public AudioClip MusicNote;

    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Bullet")) {
            GetComponent<AudioSource>().PlayOneShot(MusicNote);
            // GetComponent<AudioSource>().Play();
        }
    }

    void OnTriggerEnter(Collider other) {
        Debug.Log("Do it");
        if (other.gameObject.CompareTag("Player")){

            GetComponent<AudioSource>().PlayOneShot(MusicNote);
            // GetComponent<AudioSource>().Play();
        }
    }
}
