using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActive : MonoBehaviour
{
    public GameObject ControlPanel, CloseButton, miniMap, data;

    void Update()
    {
        if(Input.GetKey("tab"))
        {
            notActive_ControlPanel();
            notActive_data();
        }
    }
    public void Active_ControlPanel()
    {
        ControlPanel.SetActive(true);
        CloseButton.SetActive(true);
        miniMap.SetActive(true);
        GameObject.Find("rocket").GetComponent<rocket>().enabled = true;
    }
    public void notActive_ControlPanel()
    {
        ControlPanel.SetActive(false);
        CloseButton.SetActive(false);
        miniMap.SetActive(false);
        GameObject.Find("rocket").GetComponent<rocket>().enabled = false;
    }

    public void Active_data()
    {
        data.SetActive(true);
    }
    public void notActive_data()
    {
        data.SetActive(false);
    }
}
    




