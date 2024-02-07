using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimContent : MonoBehaviour
{
    public Animation[] animations;
    public Animation[] animationsButton;
    public Animation bG;
    public Animation back;

    public void AllAnim()
    {
        bG.Play("AnimBg");
        Debug.Log(bG.Play("AnimBg"));
        if (back != null)
        {
            back.Play("AnimBackImg");
            Debug.Log(back.Play("AnimBackImg"));
        }
        for (int i = 0; i < animations.Length; i++)
        {
            animations[i].Play("AnimContent");
            Debug.Log(animations[i].Play("AnimContent"));
        }
        for (int i = 0; i < animationsButton.Length; i++)
        {
            animationsButton[i].Play("AnimButton");
            Debug.Log(animationsButton[i].Play("AnimButton"));
        }
    }
    public void AllAnim1()
    {
        bG.Play("AnimBg2");
        Debug.Log(bG.Play("AnimBg2"));
        if (back != null)
        {
            back.Play("AnimBackImgP");
            Debug.Log(back.Play("AnimBackImgP"));
        }
        for (int i = 0; i < animations.Length; i++)
        {
            animations[i].Play("AnimContent1");
            Debug.Log(animations[i].Play("AnimContent1"));
        }
        for (int i = 0; i < animationsButton.Length; i++)
        {
            animationsButton[i].Play("AnimButton1");
            Debug.Log(animationsButton[i].Play("AnimButton1"));
        }
    }  
    public void AllAnim2()
    {
        bG.Play("AnimBg2");
        Debug.Log(bG.Play("AnimBg2"));
        if (back != null)
        {
            back.Play("AnimBackImgP");
            Debug.Log(back.Play("AnimBackImgP"));
        }
        for (int i = 0; i < animations.Length; i++)
        {
            animations[i].Play("AnimContent2");
            Debug.Log(animations[i].Play("AnimContent2"));
        }
        for (int i = 0; i < animationsButton.Length; i++)
        {
            animationsButton[i].Play("AnimButton2");
            Debug.Log(animationsButton[i].Play("AnimButton2"));
        }
    }
    public void AllAnimP()
    {
        if (back != null)
        {
            back.Play("AnimBackImgP");
            Debug.Log(back.Play("AnimBackImgP"));
        }
        for (int i = 0; i < animations.Length; i++)
        {
            animations[i].Play("AnimContentP");
            Debug.Log(animations[i].Play("AnimContentP"));
        }
        for (int i = 0; i < animationsButton.Length; i++)
        {
            animationsButton[i].Play("AnimButtonP");
            Debug.Log(animationsButton[i].Play("AnimButtonP"));
        }
    }
    public void AllAnim_2()
    {
        bG.Play("AnimBG2_2");
        Debug.Log(bG.Play("AnimBG2_2"));
    }
}
