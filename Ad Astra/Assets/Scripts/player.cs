using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    public void Update()
    { 
        movement();    
    }

    public void movement()
    {
        if(Input.GetKey("d"))
        {
            gameObject.transform.Translate(0.008f, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }
        else if (Input.GetKey("a"))
        {
            gameObject.transform.Translate(-0.008f, 0, 0);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }
    }
}
