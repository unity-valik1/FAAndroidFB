using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{

    [SerializeField] private Animation anim;

    public int sceneID;
    public GameObject img1;
    public GameObject img2;
    public GameObject img3;
    public string textLoading;
    public TMP_Text textLoadingDot;
    public GameObject textSay1;
    public GameObject textSay2;
    public GameObject textSay3;
    public GameObject textAuthor1;
    public GameObject textAuthor2;
    public GameObject textAuthor3;
    
    int go = 0;
    public float rateDot = 0.3f;
    public float nextText;

    void Start()
    {
        ImgRandom();
        SayRandom();
        textLoading = textLoadingDot.text;
        textLoadingDot.text = "Loading";
        Invoke("Invoker1", 2.5f);
        Invoke("Invoker", 3f);
    }
    public void Invoker1()
    {
        anim.Play("LoadingScenesAnim");
    }
    private void Update()
    {
        if(nextText <= 0)
        {
            if (go == 3)
            {
                textLoadingDot.text += ".";
                go -=3;
                nextText = rateDot;

            }
            else if (go == 2)
            {
                textLoadingDot.text += ".";
                go++;
                nextText = rateDot;
            }
            else if (go == 1)
            {
                textLoadingDot.text += ".";
                go++;
                nextText = rateDot;
            }
            else if (go == 0)
            {
                textLoadingDot.text = "Loading";
                go++;
                nextText = rateDot;
            }
        }     
        else if (nextText > 0)
        {
            nextText -= Time.deltaTime;
        }
        print(nextText);
    }

    IEnumerator AsyncLoad()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneID);

        while (operation.isDone)
        {
            if (!operation.allowSceneActivation)
            {
                operation.allowSceneActivation = true;
            }
            yield return null;
        }
    }

    public void Invoker()
    {
        StartCoroutine(AsyncLoad());
    }

    public void ImgRandom()
    {
        int a = Random.Range(0, 3);
        if (a == 0)
        {
            img1.SetActive(true);
            img2.SetActive(false);
            img3.SetActive(false);
        }
        else if (a == 1)
        {
            img1.SetActive(false);
            img2.SetActive(true);
            img3.SetActive(false);
        }
        else if (a == 2)
        {
            img1.SetActive(false);
            img2.SetActive(false);
            img3.SetActive(true);
        }
    }

    public void SayRandom()
    {
        int b = Random.Range(0, 3);
        if (b == 0)
        {
            textSay1.SetActive(true);
            textSay2.SetActive(false);
            textSay3.SetActive(false);
            textAuthor1.SetActive(true);
            textAuthor2.SetActive(false);
            textAuthor3.SetActive(false);
        }
        else if (b == 1)//если b = 1
        {
            textSay1.SetActive(false);
            textSay2.SetActive(true);
            textSay3.SetActive(false);
            textAuthor1.SetActive(false);
            textAuthor2.SetActive(true);
            textAuthor3.SetActive(false);
        }
        else if (b == 2)//если b = 2
        {
            textSay1.SetActive(false);
            textSay2.SetActive(false);
            textSay3.SetActive(true);
            textAuthor1.SetActive(false);
            textAuthor2.SetActive(false);
            textAuthor3.SetActive(true);
        }
    }
}
