using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound_Mat : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    //public bool switchMaterial = true;
    public int i;

    public AK.Wwise.Event MalletSound, StickSound;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        
    }
   
    
    void OnCollisionEnter(Collision col)
    {
        

        if(col.gameObject.tag == "Mallet")
        {   
            rend.sharedMaterial = material[1];
            MalletSound.Post(gameObject);
        }

        if (col.gameObject.tag == "Stick")
        {
            rend.sharedMaterial = material[1];
            StickSound.Post(gameObject);
        }

    }

    void OnCollisionExit(Collision col)
    {
        rend.sharedMaterial = material[0];
    }

}
