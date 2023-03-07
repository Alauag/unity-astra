using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detect : MonoBehaviour
{
    public GameObject cp, cb, mp, b;
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
                color = 0;
                b.GetComponent<SpriteRenderer>().color = color_list[color];
            }
        }
    }
}
