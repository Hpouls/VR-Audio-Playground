using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tangColourChange : MonoBehaviour
{
    public Material[] material;
    Renderer rend;
    public bool switchMaterial = true;
    public int i;

    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
        
    }

    // Update is called once per frame
    void Update()
    {
        if (switchMaterial == true){
            i = 0;
        }
        else
        {
            i = 1;
        }

        rend.sharedMaterial = material[i];
        switchMaterial = !switchMaterial;
       

    }
}
