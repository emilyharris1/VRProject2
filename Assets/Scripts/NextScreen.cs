using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScreen : MonoBehaviour
{
    void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Bullet")){
            SceneManager.LoadScene("TeleportScreen");
        }
    }
    void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Player")){
            SceneManager.LoadScene("RaycastScreen");
        }
    }
}
