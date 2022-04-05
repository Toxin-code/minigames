using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ButtonFx : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;
    float time = 0f;

    public void ClickSound()
    {
        myFx.PlayOneShot(clickFx);
        StartCoroutine(waiter());
    }

    IEnumerator waiter()
    {
        if (GameObject.Find("CowButton") == true)
        {
            GameObject.Find("CowButton").GetComponent<EventTrigger>().enabled = false;
            yield return new WaitForSeconds(2);
            GameObject.Find("CowButton").GetComponent<EventTrigger>().enabled = true;
        }

        if (GameObject.Find("ChickenButton") == true)
        {
            GameObject.Find("ChickenButton").GetComponent<EventTrigger>().enabled = false;
            yield return new WaitForSeconds(4);
            GameObject.Find("ChickenButton").GetComponent<EventTrigger>().enabled = true;
        }

        if (GameObject.Find("DuckButton") == true)
        {
            GameObject.Find("DuckButton").GetComponent<EventTrigger>().enabled = false;
            yield return new WaitForSeconds(6);
            GameObject.Find("DuckButton").GetComponent<EventTrigger>().enabled = true;
        }

        if (GameObject.Find("CatButton") == true)
        {
            GameObject.Find("CatButton").GetComponent<EventTrigger>().enabled = false;
            yield return new WaitForSeconds(6);
            GameObject.Find("CatButton").GetComponent<EventTrigger>().enabled = true;
        }

        if (GameObject.Find("SheepButton") == true)
        {                    
            GameObject.Find("SheepButton").GetComponent<EventTrigger>().enabled = false;
            yield return new WaitForSeconds(2);
            GameObject.Find("SheepButton").GetComponent<EventTrigger>().enabled = true;
        }

        if (GameObject.Find("OldButton") == true)
        {
            GameObject.Find("OldButton").GetComponent<EventTrigger>().enabled = false;
            yield return new WaitForSeconds(3);
            GameObject.Find("OldButton").GetComponent<EventTrigger>().enabled = true;
        }

        if (GameObject.Find("DogButton") == true)
        {
            GameObject.Find("DogButton").GetComponent<EventTrigger>().enabled = false;
            yield return new WaitForSeconds(4);
            GameObject.Find("DogButton").GetComponent<EventTrigger>().enabled = true;
        }

        if (GameObject.Find("ParrotButton") == true)
        {
            GameObject.Find("ParrotButton").GetComponent<EventTrigger>().enabled = false;
            yield return new WaitForSeconds(5);
            GameObject.Find("ParrotButton").GetComponent<EventTrigger>().enabled = true;
        }
    }
}
