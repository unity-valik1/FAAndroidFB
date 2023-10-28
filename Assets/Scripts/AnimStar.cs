using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimStar : MonoBehaviour
{
    public Animation star;

    public void StarAnim()
    {
        star.Play("AnimStar");
    }
}
