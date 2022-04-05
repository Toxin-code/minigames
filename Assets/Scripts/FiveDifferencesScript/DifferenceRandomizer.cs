using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferenceRandomizer : MonoBehaviour
{
    public GameObject pref1;
    public GameObject pref2;
    public GameObject pref3;
    public GameObject pref4;
    public GameObject pref5;
    public GameObject pref6;
    public GameObject pref7;
    public GameObject pref8;
    public GameObject pref9;
    public GameObject pref10;
    System.Random r = new System.Random();

    void Start()
    {
        int i = r.Next(1, 11);

        if (i == 1) pref1.SetActive(true);
        if (i == 2) pref2.SetActive(true);
        if (i == 3) pref3.SetActive(true);
        if (i == 4) pref4.SetActive(true);
        if (i == 5) pref5.SetActive(true);
        if (i == 6) pref6.SetActive(true);
        if (i == 7) pref7.SetActive(true);
        if (i == 8) pref8.SetActive(true);
        if (i == 9) pref9.SetActive(true);
        if (i == 10) pref10.SetActive(true);

    }
}
