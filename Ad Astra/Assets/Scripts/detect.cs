using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detect : MonoBehaviour
{
    public GameObject ControlPanel, CloseButton, miniMap, DetectButton, OutButton, BackButton, wdc, window;
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

    void OnTriggerStay2D(Collider2D col) 
    {
        if(col.gameObject.tag == "planet")
        {
            if(Input.GetKey("e"))
            {
                ControlPanel.SetActive(false);
                CloseButton.SetActive(false);
                miniMap.SetActive(false);
                wdc.SetActive(true);
                window.SetActive(false);

                color = 0;
                DetectButton.GetComponent<Image>().color = color_list[color];
                OutButton.GetComponent<Image>().color = color_list[color];
                BackButton.GetComponent<Image>().color = color_list[color];
                GameObject.Find("Control Panel Button").GetComponent<Button>().enabled = false;
                GameObject.Find("rocket").GetComponent<rocket>().enabled = false;
                GameObject.Find("detectButton").GetComponent<Button>().enabled = true;
                GameObject.Find("backButton").GetComponent<Button>().enabled = true;
                GameObject.Find("outButton").GetComponent<Button>().enabled = true;
                
                if(col.gameObject.name == "planetLine1")
                {
                    showData.degree = 0;
                    showData.Name = "violet";
                    showData.element = "water";
                    showData.feature = "???";
                    showData.type = "small";
                    showData.warning = "safe";
                }
            }
        }
    }
}
