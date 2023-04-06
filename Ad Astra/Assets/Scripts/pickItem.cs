using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickItem : MonoBehaviour
{
    public Item item;
    public MainItem mainItem;
    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.name == "player")
        {
            if(Input.GetKey("f"))
			{
                AddNewItem(); 
                Destroy(gameObject);
            }
        }
    }

    public void AddNewItem()
    {
        if(!mainItem.itemList.Contains(item))
            {
                for(int i = 0; i < mainItem.itemList.Count; i++)
                {
                    if(mainItem.itemList[i] == null)
                    {
                        mainItem.itemList[i] = item;
                        break;
                    }
                }
            }
            else
            {
                item.itemNum += 1;
            }

            InventoryManager.updateItemToUI();
        
    }
}
