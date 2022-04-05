using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackSoundCatcher : MonoBehaviour
{
    private void Awake()
    {
        GameObject obj = GameObject.FindWithTag("BackGroundMusicMain");
        
        if (obj != null)
        {
            Destroy(obj);
        } 
    }
}
