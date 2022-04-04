using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighTone : MonoBehaviour {

    private AudioSource source;

    void Start() {
        source = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other){
        if (other.tag == "DrumStickHead") {
            source.pitch = 1.2f;
            source.Play();
        }
    }
}
