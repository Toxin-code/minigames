using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class MovingPuzzle : MonoBehaviour
{
    public GameObject EndMenu;
    public GameObject selectedPiece;
    public int PlacedPieces = 0;
    int OIL = -16;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            try
            {
                RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

                if (hit.transform.CompareTag("Puzzle"))
                {
                    if (!hit.transform.GetComponent<PiecesScript>().InRightPosition)
                    {
                        selectedPiece = hit.transform.gameObject;
                        selectedPiece.GetComponent<PiecesScript>().Selected = true;
                        selectedPiece.GetComponent<SpriteRenderer>().sortingOrder = OIL;
                        OIL++;
                    }
                }               
            }
            catch
            {
            }           
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (selectedPiece != null)
            {
                if (OIL > 4)
                {
                    OIL = -16;
                }

                selectedPiece.GetComponent<PiecesScript>().Selected = false;
                selectedPiece = null;
            }
        }
        if (selectedPiece != null)  
        {
            Vector3 MousePoint = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            selectedPiece.transform.position = new Vector3(MousePoint.x, MousePoint.y, 0);
        }
        if (PlacedPieces == 16)
        {
            GameObject.Find("PauseButton").SetActive(false);
            EndMenu.SetActive(true);
        }
    }
}
