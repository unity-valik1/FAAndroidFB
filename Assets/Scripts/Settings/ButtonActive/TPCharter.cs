using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPCharter : MonoBehaviour
{
    [Header("������� ������������ � ������")]
    public GameObject[] tPcCharter;
    public void C1()
    {
        for (int i = 0; i < tPcCharter.Length; i++)
        {
            tPcCharter[i].transform.position = new Vector3(transform.position.x, 0, 0);
        }
    }
}
