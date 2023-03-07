using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class limitPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -142.31f, -29.6f), Mathf.Clamp(transform.position.y, -8.18f, 56.4f), transform.position.z);
    }
}
