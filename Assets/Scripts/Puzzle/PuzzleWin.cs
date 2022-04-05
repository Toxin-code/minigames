using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleWin : MonoBehaviour
{
    int fullElement;

    public static int myElement;
    public GameObject myPuzzle;
    public GameObject myPanel;
    public GameObject winPanel;

    private void Start()
    {
        fullElement = myPuzzle.transform.childCount;
    }

    private void Update()
    {
        if (fullElement == myElement)
        {
            myPanel.SetActive(false);
            winPanel.SetActive(true);
        }
    }
    public static void AddElement()
    {
        myElement++;
    }
}
