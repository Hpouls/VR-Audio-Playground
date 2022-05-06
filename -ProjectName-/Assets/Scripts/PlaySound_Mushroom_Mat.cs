using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound_Mushroom_Mat : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    //public bool switchMaterial = true;
    public bool soundOn = false;

    public AK.Wwise.Event MushroomSound;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        
    }
   
    
    void OnCollisionEnter(Collision col)
    {
        if(soundOn == false)
        {
            if(col.gameObject.tag == "Mallet")
            {   
                rend.sharedMaterial = material[1];
                MushroomSound.Post(gameObject);
            }
            if (col.gameObject.tag == "Stick")
            {
                rend.sharedMaterial = material[1];
                MushroomSound.Post(gameObject);
            }
            ;
        }

        if (soundOn == true)
        {
            rend.sharedMaterial = material[0];
            MushroomSound.Stop(gameObject);
        }

        soundOn = !soundOn;

    }


}
