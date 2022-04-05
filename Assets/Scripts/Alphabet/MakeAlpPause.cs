using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class MakeAlpPause : MonoBehaviour
{
    public void Begin()
    {
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        GameObject.Find("PlayFullAlphabet").GetComponent<EventTrigger>().enabled = false;
        yield return new WaitForSeconds(24);
        GameObject.Find("PlayFullAlphabet").GetComponent<EventTrigger>().enabled = true;     
    }
}
