using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class ItemOnDrag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public MainItem mainItem;
    public Transform originalParent;
    private int currentItemID; //當前物品ID
    public void OnBeginDrag(PointerEventData eventData)
    {
        originalParent = transform.parent;
        currentItemID = originalParent.GetComponent<Grid>().gridID;
        transform.SetParent(transform.parent.parent);
        transform.position = eventData.position;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if(eventData.pointerCurrentRaycast.gameObject.name == "Item Image")
        {
            transform.SetParent(eventData.pointerCurrentRaycast.gameObject.transform.parent.parent);
            transform.position = eventData.pointerCurrentRaycast.gameObject.transform.parent.parent.position;
            //itemList的物品存儲位置改變
            var temp = mainItem.itemList[currentItemID];
            mainItem.itemList[currentItemID] = mainItem.itemList[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Grid>().gridID];
            mainItem.itemList[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Grid>().gridID] = temp;

            eventData.pointerCurrentRaycast.gameObject.transform.parent.SetParent(originalParent);
            eventData.pointerCurrentRaycast.gameObject.transform.parent.position = originalParent.position;
            GetComponent<CanvasGroup>().blocksRaycasts = true;
            return;
        }
        transform.SetParent(eventData.pointerCurrentRaycast.gameObject.transform);
        transform.position = eventData.pointerCurrentRaycast.gameObject.transform.position;
        //itemList的物品存儲位置改變
        mainItem.itemList[eventData.pointerCurrentRaycast.gameObject.GetComponentInParent<Grid>().gridID] = mainItem.itemList[currentItemID];
        mainItem.itemList[currentItemID] = null;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
