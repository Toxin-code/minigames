using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class False : MonoBehaviour
{
    bool lie = false;
    public GameObject EndMenu;
    public GameObject Pause;

    private void Update()
    {
        if (lie == true)
        {
            EndMenu.SetActive(true);
            Pause.SetActive(false);
        }
    }
    public void GoTrue()
    {
        lie = true;
    }
}
