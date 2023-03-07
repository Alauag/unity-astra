using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject cp, cb, mp;
    public void Active_cp()
    {
        cp.SetActive(true);
        cb.SetActive(true);
        mp.SetActive(true);
    }
    public void notActive_cp()
    {
        cp.SetActive(false);
        cb.SetActive(false);
        mp.SetActive(false);
    }
}
