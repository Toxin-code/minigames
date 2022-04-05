using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RndWord : MonoBehaviour
{
    public GameObject rightObject;
    public AudioSource myFx;
    public AudioClip win;
    public AudioClip lose;
    public AudioClip[] tryToFind = new AudioClip[33];
    public Sprite[] sorArr = new Sprite[2];
    public Image img;
    private int game = 0;
    List<GameObject> nums = new List<GameObject>();
    List<GameObject> fullSoundButtonList = new List<GameObject>();
    System.Random r = new System.Random();
    int keyNum = 0;
    int test = 0;
    

    public void Begin()
    {

        if (game % 2 == 0)
        {
            img.sprite = sorArr[1];
            int key = r.Next(1, 33);
            keyNum = key;

            Debug.Log($"Ключ: {key}");
            
            StartCoroutine(waiter());
            for (int i = 1; i < 34; i++)
            {
                if (key == i)
                {
                    Invoke($"Play{i}", 1); 
                }
            }        

            for (int i = 1; i < 34; i++)
            {
                fullSoundButtonList.Add(GameObject.Find(System.Convert.ToString(i))); 
            }
            Debug.Log($"Кол-во всех: {fullSoundButtonList.Count}");

            foreach (var item in fullSoundButtonList)
            {
                item.GetComponent<MakeSound>().iterator = item.GetComponent<MakeSound>().iterator = 1;
            }

            for (int i = 1; i < 34; i++)
            {
                if (i == keyNum)
                {
                    continue;
                }

                nums.Add(GameObject.Find(System.Convert.ToString(i))); 
            }
            Debug.Log($"Кол-во всех кроме ключевой: {nums.Count}");

            foreach (var item in nums)
            {                
                item.GetComponent<Button>().onClick.AddListener(Lose);                              
            }

            rightObject = GameObject.Find($"{keyNum}");
            rightObject.GetComponent<Button>().onClick.AddListener(Win); 
            
        }
        else if(game % 2 == 1)
        {
            img.sprite = sorArr[0];
            foreach (var item in fullSoundButtonList)
            {
                item.GetComponent<MakeSound>().iterator = 0;            
            }


            foreach (var item in nums)
            {
                item.GetComponent<Button>().onClick.RemoveListener(Lose); 
            }
            Debug.Log($"Кол-во всех удаленных кроме ключа до: {nums.Count}");
            nums.Clear();
            Debug.Log($"Кол-во всех удаленных кроме ключа после: {nums.Count}");

            fullSoundButtonList.Clear();
            Debug.Log($"Кол-во всех удаленных: {fullSoundButtonList.Count}");

            rightObject = GameObject.Find($"{keyNum}");
            rightObject.GetComponent<Button>().onClick.RemoveListener(Win); 
        }

        game++;
    }

    IEnumerator waiter()
    {
        GameObject.Find("Воспроизведение").GetComponent<EventTrigger>().enabled = false;
        yield return new WaitForSeconds(6f);
        GameObject.Find("Воспроизведение").GetComponent<EventTrigger>().enabled = true;
    }

    public void Win() 
    {               
        myFx.PlayOneShot(win);
        Begin();
        Debug.Log("Итерация успешна");
    }

    public void Lose() 
    {
        myFx.PlayOneShot(lose);
    }

    public void Play1()
    {
        myFx.PlayOneShot(tryToFind[0]);
    }
    public void Play2()
    {
        myFx.PlayOneShot(tryToFind[1]);
    }
    public void Play3()
    {
        myFx.PlayOneShot(tryToFind[2]);
    }
    public void Play4()
    {
        myFx.PlayOneShot(tryToFind[3]);
    }
    public void Play5()
    {
        myFx.PlayOneShot(tryToFind[4]);
    }
    public void Play6()
    {
        myFx.PlayOneShot(tryToFind[5]);
    }
    public void Play7()
    {
        myFx.PlayOneShot(tryToFind[6]);
    }
    public void Play8()
    {
        myFx.PlayOneShot(tryToFind[7]);
    }
    public void Play9()
    {
        myFx.PlayOneShot(tryToFind[8]);
    }
    public void Play10()
    {
        myFx.PlayOneShot(tryToFind[9]);
    }
    public void Play11()
    {
        myFx.PlayOneShot(tryToFind[10]);
    }
    public void Play12()
    {
        myFx.PlayOneShot(tryToFind[11]);
    }
    public void Play13()
    {
        myFx.PlayOneShot(tryToFind[12]);
    }
    public void Play14()
    {
        myFx.PlayOneShot(tryToFind[13]);
    }
    public void Play15()
    {
        myFx.PlayOneShot(tryToFind[14]);
    }
    public void Play16()
    {
        myFx.PlayOneShot(tryToFind[15]);
    }
    public void Play17()
    {
        myFx.PlayOneShot(tryToFind[16]);
    }
    public void Play18()
    {
        myFx.PlayOneShot(tryToFind[17]);
    }
    public void Play19()
    {
        myFx.PlayOneShot(tryToFind[18]);
    }
    public void Play20()
    {
        myFx.PlayOneShot(tryToFind[19]);
    }
    public void Play21()
    {
        myFx.PlayOneShot(tryToFind[20]);
    }
    public void Play22()
    {
        myFx.PlayOneShot(tryToFind[21]);
    }
    public void Play23()
    {
        myFx.PlayOneShot(tryToFind[22]);
    }
    public void Play24()
    {
        myFx.PlayOneShot(tryToFind[23]);
    }
    public void Play25()
    {
        myFx.PlayOneShot(tryToFind[24]);
    }
    public void Play26()
    {
        myFx.PlayOneShot(tryToFind[25]);
    }
    public void Play27()
    {
        myFx.PlayOneShot(tryToFind[26]);
    }
    public void Play28()
    {
        myFx.PlayOneShot(tryToFind[27]);
    }
    public void Play29()
    {
        myFx.PlayOneShot(tryToFind[28]);
    }
    public void Play30()
    {
        myFx.PlayOneShot(tryToFind[29]);
    }
    public void Play31()
    {
        myFx.PlayOneShot(tryToFind[30]);
    }
    public void Play32()
    {
        myFx.PlayOneShot(tryToFind[31]);
    }
    public void Play33()
    {
        myFx.PlayOneShot(tryToFind[32]);
    }
}
