using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardBackPrefab : MonoBehaviour
{
    public GameObject Deck;
    public GameObject cardBack;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Deck = GameObject.Find("Deck Panel");
        cardBack.transform.SetParent(Deck.transform);
        cardBack.transform.localScale = Vector3.one;
        cardBack.transform.position = new Vector3(transform.position.x, transform.position.y, -48);
        cardBack.transform.eulerAngles = new Vector3(25, 0, 0);
    }
}
