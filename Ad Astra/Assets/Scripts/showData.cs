using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class showData : MonoBehaviour
{
    public TextMeshProUGUI Tname, Tdegree, Telement, Tfeature, Ttype, Twarning;
    public static int degree;
    public static string Name, element, feature, type, warning;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        show();
    }

    private void show()
    {
        Tname.text = Name;
        Tdegree.text = degree.ToString() + "%";
        Telement.text = "Element:" + element;
        Tfeature.text = "Feature:" + feature;
        Ttype.text = "Type:" + type;
        Twarning.text = "Warning:" + warning;
    }
}
