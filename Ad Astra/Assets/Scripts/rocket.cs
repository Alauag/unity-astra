using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket : MonoBehaviour
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
        if(Input.GetKey("w"))
        {
            gameObject.transform.Translate(0, 0.04f, 0);
        }
        if (Input.GetKey("a"))
        {
            gameObject.transform.Rotate( 0, 0, 1);
        }
        else if (Input.GetKey("d"))
        {
            gameObject.transform.Rotate( 0, 0, -1);
        }



    }
}
