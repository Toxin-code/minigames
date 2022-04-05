using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Right : MonoBehaviour
{
    bool right = false;
    public GameObject EndMenu;
    public GameObject Pause;

    private void Update()
    {
        if (right == true)
        {
            EndMenu.SetActive(true);
            Pause.SetActive(false);
        }
    }

    public void GoTrue()
    {
        right = true;
    }
}
