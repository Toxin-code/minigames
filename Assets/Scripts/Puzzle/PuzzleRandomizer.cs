using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleRandomizer : MonoBehaviour
{
    public GameObject[] puzzles = new GameObject[9];
    public GameObject[] clips = new GameObject[4];
    
    System.Random r = new System.Random();
    void Start()
    {
        int i = r.Next(1, 6);

        if (i == 1)
        {
            puzzles[0].SetActive(true);
            clips[0].SetActive(true);
        }
        if (i == 2)
        {
            puzzles[1].SetActive(true);
            clips[1].SetActive(true);
        }
        if (i == 3)
        {
            puzzles[2].SetActive(true);
            clips[2].SetActive(true);
        }
        if (i == 4)
        { 
            puzzles[3].SetActive(true);
            clips[3].SetActive(true);
        }
        if (i == 5)
        {
            puzzles[4].SetActive(true);
            clips[4].SetActive(true);
        }
    }

    void Update()
    {
        
    }
}
