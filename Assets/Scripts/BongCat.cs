using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BongCat : MonoBehaviour
{
    public float Second = 0.5f;
    public Image img;
    public Sprite[] sorArr = new Sprite[7];

    private void Start()
    {
        StartCoroutine(WaitALittle());
    }
    
    IEnumerator WaitALittle()
    {
        while (true)
        {
            for (int i = 0; i < sorArr.Length; i++)
            {
                img.sprite = sorArr[i];
                yield return new WaitForSeconds(Second);
            }
        }      
    }
}
