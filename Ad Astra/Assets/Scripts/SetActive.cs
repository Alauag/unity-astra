using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    public GameObject ControlPanel, CloseButton, miniMap;
    public void Active_ControlPanel()
    {
        ControlPanel.SetActive(true);
        CloseButton.SetActive(true);
        miniMap.SetActive(true);
    }
    public void notActive_ControlPanel()
    {
        ControlPanel.SetActive(false);
        CloseButton.SetActive(false);
        miniMap.SetActive(false);
    }
}
