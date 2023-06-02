using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BakeryScript : MonoBehaviour
{
    public GameObject bakery_pic, cammm, player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    private void OnTriggerStay2D(Collider2D collision) {
        if (Input.GetKey("e")) {
            bakery_pic.SetActive(true);
            player.SetActive(false);
        }
    }
}
