using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MidTone : MonoBehaviour {

    private AudioSource source;

    void Start() {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "DrumStickHead") {
            source.pitch = 1f;
            source.Play();
        }
    }
}
