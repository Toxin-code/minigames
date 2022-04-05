﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddButtons : MonoBehaviour
{
    [SerializeField]
    private Transform pazzleField;

    [SerializeField]
    private GameObject btn;

    private void Awake()
    {
        for (int i = 0; i < 18; i++)
        {
            GameObject button = Instantiate(btn);
            button.name = "" + i;
            button.transform.SetParent(pazzleField, false);
        }
    }
}
