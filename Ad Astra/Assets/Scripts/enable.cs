using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void rocketMove()
    {
        GameObject.Find("rocket").GetComponent<rocket>().enabled = true;
    }
    public void rocketNotMove()
    {
        GameObject.Find("rocket").GetComponent<rocket>().enabled = false;
    }
}
