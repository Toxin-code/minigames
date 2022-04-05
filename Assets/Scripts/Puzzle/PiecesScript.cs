using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class PiecesScript : MonoBehaviour
{
    bool finish = false;
    int count = 0;
    Vector3 RightPosition;
    public bool InRightPosition;
    public bool Selected;

    private void Awake()
    {
        RightPosition = transform.position;
        transform.position = new Vector3(Random.Range(0f, 9f), Random.Range(4f, -4f), 0);
    }

    private void Update()
    {       
        if (Vector3.Distance(transform.position, RightPosition) < 0.2f)
        {
            if (!Selected)
            {
                if (InRightPosition == false)
                {
                    transform.position = RightPosition;
                    InRightPosition = true;
                    GetComponent<SpriteRenderer>().sortingOrder = -16;
                    Camera.main.GetComponent<MovingPuzzle>().PlacedPieces++;
                }
            }
        }
        
        
    }
}
