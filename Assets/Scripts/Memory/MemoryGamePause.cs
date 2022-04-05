using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemoryGamePause : MonoBehaviour
{
    int count = 0;
    public GameObject Menu;
    bool active = false;
    

    public void PauseContinue()
    {
        if (count % 2 == 0)
        {
            Menu.SetActive(true);
            count++;
        }
        else
        {
            Menu.SetActive(false);
            count++;
        }
    }
}
