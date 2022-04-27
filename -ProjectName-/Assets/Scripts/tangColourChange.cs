using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tangColourChange : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    //public bool switchMaterial = true;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        
    }
   
    
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Tool")
        {
                rend.sharedMaterial = material[1];
        }
        
    }

    void OnCollisionExit(Collision col)
    {
        rend.sharedMaterial = material[0];
    }

}
