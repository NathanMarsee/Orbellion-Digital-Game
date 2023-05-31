using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler
{
    public Draggable.WhoseCard card = Draggable.WhoseCard.PlayerCard;
    public void OnPointerEnter(PointerEventData eventData){
        //Debug.Log("OnPointerEnter");
        if(eventData.pointerDrag == null){
            return;
        }

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null){
            if(card == d.card){
                d.parentToReturnTo = this.transform;
            }
        }
    }

    public void OnPointerExit(PointerEventData eventData){
        //Debug.Log("OnPointerExit");
        if(eventData.pointerDrag == null){
            return;
        }

        Draggable d = eventData.pointerDrag.GetComponent<Draggable>();
        if(d != null && d.placeholderParent == this.transform){
            if(card == d.card){
                d.placeholderParent = d.parentToReturnTo;
            }
        }
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
