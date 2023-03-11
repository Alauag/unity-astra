using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back : MonoBehaviour
{
    public GameObject DetectButton, OutButton, BackButton, wdc, window;
    public Color[] color_list;
    int color;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Back()
    {
        color = 0;
        DetectButton.GetComponent<Image>().color = color_list[color];
        OutButton.GetComponent<Image>().color = color_list[color];
        BackButton.GetComponent<Image>().color = color_list[color];
        wdc.SetActive(false);
        window.SetActive(true);
        GameObject.Find("Control Panel Button").GetComponent<Button>().enabled = true;
        GameObject.Find("detectButton").GetComponent<Button>().enabled = false;
        GameObject.Find("backButton").GetComponent<Button>().enabled = false;
        GameObject.Find("outButton").GetComponent<Button>().enabled = false;
    }
}
