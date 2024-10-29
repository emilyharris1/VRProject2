using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    [SerializeField]
    private string objectName = null;
    [SerializeField]
    private LayerMask raycastMask;

    void Start()
    {
    }

    void Update()
    {
        RaycastHit hit;
        bool didHit = Physics.Raycast(transform.position, transform.forward, out hit, Mathf.Infinity, raycastMask);
       
        if (didHit && hit.collider.gameObject.name != objectName){
            hit.collider.gameObject.GetComponent<AudioSource>().Play();
            objectName = hit.collider.gameObject.name;
        } else if (!didHit) {
            objectName = null;
        }
    }
}
/*
    Did I just play a sound? (track with a bool)
    - Reset this when the raycast doest hit

    Something can cast a ray and detect what it hits
    - Then play a sound based on that thing (probably call a function on it)

    Sound Object
    - Need to have an audio source
    - Needs to have a different name

    Raycaster
    - Needs a private class variable that's a string intialize as null
    - In Update
        - every frame do a raycast
        - If there is a hit and the name does not match our stored name -> hitobject.GetComponent<AudioSource>().Play() and assign the class variable to that objects name
        - If not hit, set stored name = null
*/