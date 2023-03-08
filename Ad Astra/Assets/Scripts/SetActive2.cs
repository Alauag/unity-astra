using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive2 : MonoBehaviour
{
    public GameObject data;
    public void Active_cp()
    {
        data.SetActive(true);
    }
    public void notActive_cp()
    {
        data.SetActive(false);
    }
}
