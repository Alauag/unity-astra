using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detect : MonoBehaviour
{
    public GameObject cp, cb, mp, db, ob, bb, wdc, window;
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
                cp.SetActive(false);
                cb.SetActive(false);
                mp.SetActive(false);
                wdc.SetActive(true);
                window.SetActive(false);

                color = 0;
                db.GetComponent<Image>().color = color_list[color];
                ob.GetComponent<Image>().color = color_list[color];
                bb.GetComponent<Image>().color = color_list[color];
                GameObject.Find("cp Button").GetComponent<Button>().enabled = false;
                GameObject.Find("rocket").GetComponent<rocket>().enabled = false;
                GameObject.Find("detectButton").GetComponent<Button>().enabled = true;
                GameObject.Find("backButton").GetComponent<Button>().enabled = true;
                GameObject.Find("outButton").GetComponent<Button>().enabled = true;
            }
        }
    }
}
