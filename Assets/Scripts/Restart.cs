using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour
{
    [SerializeField]
    private LayerMask startMask;

    void Update()
    {
        RaycastHit hit;
        bool didHit = Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, startMask);
       
        if (didHit ){
            SceneManager.LoadScene("MainScene");
        }
        
    }
}
