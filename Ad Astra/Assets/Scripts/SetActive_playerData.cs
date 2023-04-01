using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetActive_playerData : MonoBehaviour
{
    public GameObject playerData;
    // Start is called before the first frame update
    private bool activeSelf = false;
    public ScrollRect scrollRect;
    private float currentTime = 0f;
    void Start()
    { 
        playerData.SetActive(false);   
    }
    
    void Update()
    { 
        Active_playerData();
    }
 
    public void Active_playerData()
    {
        currentTime += Time.deltaTime;
        if(Input.GetKey("tab"))
        {
           if(currentTime < 0.5f) return;
           if(activeSelf == false) activeSelf = true;
           else activeSelf = false;
           if(activeSelf == true) playerData.SetActive(true);
           else playerData.SetActive(false);
           scrollRect.verticalNormalizedPosition = 1;
           currentTime = 0;
        }
    }
}
