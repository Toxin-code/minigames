using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FindDifference : MonoBehaviour
{
    private bool chosen;
    private Button myButton;
    private Image myImage;
    GameObject Counter;
    void Start()
    {
        myButton = GetComponent<Button>();
        myImage = GetComponent<Image>();
        myButton.onClick.AddListener(MyVoid);
    }
    void MyVoid()
    {
        myImage.color = Color.white;
        myButton.enabled = false;
        Counter = GameObject.Find("Counter");
        Counter.GetComponent<Counter>().count++;
    }
}
