using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class Grid : MonoBehaviour
{
    public int gridID; //空格ID等於物品ID
    public Image gridImage;
    public TextMeshProUGUI girdNum;
    public Item girdItem;
    public GameObject itemInGrid;
    public string gridInfo;

    public void ItemOnClock()
    {
        InventoryManager.updateItemInfo(gridInfo);
    }

    public void SetUpGrid(Item item)
    {
        if(item == null)
        {
           itemInGrid.SetActive(false);
           return;
        }
        gridImage.sprite = item.itemImage;
        girdNum.text = item.itemNum.ToString();
        gridInfo = item.itemInfo;
    }
}
