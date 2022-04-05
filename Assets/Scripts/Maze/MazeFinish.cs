using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazeFinish : MonoBehaviour
{
    private bool FinishPlane = false;
    public GameObject End;
    GameObject generator;
    Vector2 position;

    public void Start()
    {
        
        
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            FinishPlane = true;
            
            if (FinishPlane == true)
            {
                GameObject.Find("MazeHero").SetActive(false);
                GameObject.Find("Floating Joystick").SetActive(false);
                GameObject.Find("PauseButton").SetActive(false);
                GameObject[] labyrinth = GameObject.FindGameObjectsWithTag("Labyrinth");

                for (int i = 0; i < labyrinth.Length; i++)
                {
                    labyrinth[i].SetActive(false);
                }

                End.SetActive(true);
            }

        }
    }
}
