using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// PermCards are permanent cards that have an effect while on the field. Each one is tied to a "baseCard" that contains the card's name, element, cost, etc., this class just listens to trigger events and reacts accordingly.
public class PermCard : MonoBehaviour
{
    Card baseCard;

    // OnEnable is called once when the gameobject is enabled
    void OnEnable()
    {
        GameRunner.OnUpkeepPhase += upkeepTrigger;
    }
    void OnDisable()
    {
        GameRunner.OnUpkeepPhase -= upkeepTrigger;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // upkeepTrigger is just an example for event-based triggers individual PermCards can have
    void upkeepTrigger()
    {

    }
}
