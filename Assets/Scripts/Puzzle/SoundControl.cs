using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundControl : MonoBehaviour
{

    public GameObject gav;
    public GameObject wolf;
    public GameObject tom;
    public GameObject ch;
    public GameObject kaz;
    public List<AudioSource> audioSources;
    
    public GameObject pause;
    int iterator = 0;

    void Update()
    {
        if (pause.activeInHierarchy && iterator%2 == 0 && gav.activeInHierarchy)
        {
            audioSources[0].Pause();        
            iterator++;
        }
        else if (!pause.activeInHierarchy && iterator%2 == 1 && gav.activeInHierarchy)
        {
            audioSources[0].Play();
            iterator++;
        }

        if (pause.activeInHierarchy && iterator % 2 == 0 && wolf.activeInHierarchy)
        {
            audioSources[1].Pause();
            iterator++;
        }
        else if (!pause.activeInHierarchy && iterator % 2 == 1 && wolf.activeInHierarchy)
        {
            audioSources[1].Play();
            iterator++;
        }

        if (pause.activeInHierarchy && iterator % 2 == 0 && tom.activeInHierarchy)
        {
            audioSources[2].Pause();
            iterator++;
        }
        else if (!pause.activeInHierarchy && iterator % 2 == 1 && tom.activeInHierarchy)
        {
            audioSources[2].Play();
            iterator++;
        }

        if (pause.activeInHierarchy && iterator % 2 == 0 && ch.activeInHierarchy)
        {
            audioSources[0].Pause();
            iterator++;
        }
        else if (!pause.activeInHierarchy && iterator % 2 == 1 && ch.activeInHierarchy)
        {
            audioSources[0].Play();
            iterator++;
        }

        if (pause.activeInHierarchy && iterator % 2 == 0 && kaz.activeInHierarchy)
        {
            audioSources[0].Pause();
            iterator++;
        }
        else if (!pause.activeInHierarchy && iterator % 2 == 1 && kaz.activeInHierarchy)
        {
            audioSources[0].Play();
            iterator++;
        }
    }
}
