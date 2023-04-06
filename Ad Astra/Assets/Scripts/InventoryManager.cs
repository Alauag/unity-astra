using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class InventoryManager : MonoBehaviour
{
    static InventoryManager instance;

    public MainItem mainItem;
    public GameObject gridPrefab;
    public GameObject myBag; 
    public TextMeshProUGUI itemInfo;
    public List<GameObject> grids = new List<GameObject>();

    private void Awake()
    {
        if(instance != null)
            Destroy(this);
        instance = this;
    }
    
    private void OnEnable()
    {
        updateItemToUI();
        instance.itemInfo.text = "";
    }
    
    /*
    public static void insertItemToUI(Item item)
    {
        
        Grid grid = Instantiate(instance.gridPrefab, instance.myBag.transform.position, Quaternion.identity);
        grid.gameObject.transform.SetParent(instance.myBag.transform);
        grid.girdItem = item;
        grid.gridImage.sprite = item.itemImage;
        grid.girdNum.text = item.itemNum.ToString();
        
    }
    */

    public static void updateItemInfo(string itemDescription)
    {
       instance.itemInfo.text = itemDescription;
    }
  
    public static void updateItemToUI()
    {
        for (int i = 0; i < instance.myBag.transform.childCount; i++)
        {
            if(instance.myBag.transform.childCount == 0)
               break;
            Destroy(instance.myBag.transform.GetChild(i).gameObject);
            instance.grids.Clear();
        }
        for (int i = 0; i < instance.mainItem.itemList.Count; i++)
        {
            //insertItemToUI(instance.mainItem.itemList[i]);
            instance.grids.Add(Instantiate(instance.gridPrefab));
            instance.grids[i].transform.SetParent(instance.myBag.transform);
            instance.grids[i].GetComponent<Grid>().gridID = i;
            instance.grids[i].GetComponent<Grid>().SetUpGrid(instance.mainItem.itemList[i]);
        }
    }
}
