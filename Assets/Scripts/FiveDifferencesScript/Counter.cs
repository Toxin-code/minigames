using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
    public int count = 0;
    bool goToFinish = false;
    public GameObject Finish;
    public GameObject Pause;

    private void Update()
    {
        if (count == 5)
        {
            goToFinish = true;

            if (goToFinish == true)
            {
                StartCoroutine(waiter());                
            }

        }
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(2);
        Finish.SetActive(true);
        Pause.SetActive(false);
    }

}
