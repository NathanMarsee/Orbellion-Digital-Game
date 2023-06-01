using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public void OnPointerEnter(PointerEventData eventData){

    }

    public void OnDrop(PointerEventData eventData){
        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null){
            d.parentToReturnTo = this.transform;
        }

        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);
    }

    public void OnPointerExit(PointerEventData eventData){

    }
}
