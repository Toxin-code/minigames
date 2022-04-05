using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeSound : MonoBehaviour
{
    public AudioSource Fx;
    public AudioClip music;
    public int iterator = 0;
    public void StartSound()
    {
        if (iterator % 2 == 0)
        {
            Fx.PlayOneShot(music);
        }
        else if (iterator % 2 == 1)
        {
            
        }
    }
}
