using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AK.Wwise;

public class UnlockCharacterLock : MonoBehaviour
{
    public GameObject destroyObject;

    void Update()
    {
        Destroy(destroyObject, 20.0f);
    }    
}
