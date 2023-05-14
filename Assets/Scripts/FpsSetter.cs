using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FpsSetter : MonoBehaviour
{
    void Awake()
    {
        Application.targetFrameRate= 120;
    }
}
