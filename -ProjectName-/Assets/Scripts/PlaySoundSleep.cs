using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundSleep : MonoBehaviour
{
    public AK.Wwise.Event MalletSound, StickSound;
    
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.tag == "Mallet")
        {   
            MalletSound.Post(gameObject);
        }

        if (col.gameObject.tag == "Stick")
        {
            StickSound.Post(gameObject);
        }
    }

}
