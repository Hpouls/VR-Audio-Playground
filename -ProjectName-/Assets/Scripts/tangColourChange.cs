using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tangColourChange : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    //public bool switchMaterial = true;
    public int i;

    public AK.Wwise.Event SomeSound;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        
    }
   
    
    void OnCollisionEnter(Collision col)
    {
        rend.sharedMaterial = material[1];

        SomeSound.Post(gameObject);
        
    }

    void OnCollisionExit(Collision col)
    {
        rend.sharedMaterial = material[0];
    }

}
