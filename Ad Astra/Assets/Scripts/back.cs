using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class back : MonoBehaviour
{
    public GameObject db, ob, bb, wdc, window;
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
        db.GetComponent<Image>().color = color_list[color];
        ob.GetComponent<Image>().color = color_list[color];
        bb.GetComponent<Image>().color = color_list[color];
        wdc.SetActive(false);
        window.SetActive(true);
        GameObject.Find("cp Button").GetComponent<Button>().enabled = true;
                GameObject.Find("rocket").GetComponent<rocket>().enabled = true;
    }
}
