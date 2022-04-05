using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    int count = 0;
    public GameObject Menu;
    public GameObject Hero;
    public GameObject Joystick;
    GameObject[] labyrinth;
    bool active = false;

    private void Start()
    {
        labyrinth = GameObject.FindGameObjectsWithTag("Labyrinth");
    }

    public void PauseContinue()
    {
        if (count % 2 == 0) 
        {
            Menu.SetActive(true);
            Hero.SetActive(false);
            Joystick.SetActive(false);
            GameObject.Find("CellSecond(Clone)").SetActive(false);

            for (int i = 0; i < labyrinth.Length; i++)
            {
                labyrinth[i].SetActive(false);
            }

            count++;
        }
        else
        {
            Menu.SetActive(false);
            Hero.SetActive(true);
            Joystick.SetActive(true);

            for (int i = 0; i < labyrinth.Length; i++)
            {
                labyrinth[i].SetActive(true);
            }
            count++;
        }
    }
}
