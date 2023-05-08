using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Draggable.WhoseCard card = Draggable.WhoseCard.PlayerCard;
    public void OnPointerEnter(PointerEventData eventData){
        //Debug.Log("OnPointerEnter");
    }

    public void OnPointerExit(PointerEventData eventData){
        //Debug.Log("OnPointerExit");
    }

    public void OnDrop(PointerEventData eventData){
        Debug.Log(eventData.pointerDrag.name + " was dropped on " + gameObject.name);

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null){
            if(card == d.card){
                d.parentToReturnTo = this.transform;
            }
        }
    }
}
