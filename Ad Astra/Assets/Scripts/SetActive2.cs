using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive2 : MonoBehaviour
{
    public GameObject data;
    public void Active_data()
    {
        data.SetActive(true);
    }
    public void notActive_data()
    {
        data.SetActive(false);
    }
}
