using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Draggable : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Transform parentToReturnTo = null;
    public void OnBeginDrag(PointerEventData eventData){
        parentToReturnTo = this.transform.parent;
        this.transform.SetParent(this.transform.parent.parent);
        GetComponent<CanvasGroup>().blocksRaycasts = false;
        Debug.Log("Begin Drag");
    }

    public void OnDrag(PointerEventData eventData){
        this.transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData){
        this.transform.SetParent(parentToReturnTo);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
        Debug.Log("End Drag");
    }
}
