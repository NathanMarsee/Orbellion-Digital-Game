using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class RegCardDisplay : MonoBehaviour
{
    public Card displayCard;
    public int displayId;
    public int id;
    public string cardName;
    public int cost;
    public int physicalPower;
    public int elementalPower;
    public string cardDescription;
    public CardType type;
    public Element element;
    public Sprite frame;
    public Sprite artwork;

    public Text nameText;
    public Text costText;
    public Text descriptionText;
    public Text typeText;

    public Image frameImage;
    public Image artworkImage;

    public bool cardBack;
    public static bool staticCardBack;


    void Start()
    {
        displayCard = this.gameObject.GetComponent<Card>();
       
        //id = displayCard.id;
        cardName = displayCard.cardName;
        cost = displayCard.cost;
        cardDescription = displayCard.cardDescription;
        type = displayCard.type;
        element = displayCard.element;
        //frame = displayCard.frame;
        //artwork = displayCard.artwork;
        frame = Resources.Load<Sprite>(displayCard.element.ToString().ToLower());
        artwork = Resources.Load<Sprite>(displayCard.cardName.Replace(" ", "_").ToLower());

        nameText.text = cardName;
        costText.text = cost.ToString("G");
        descriptionText.text = cardDescription;
        typeText.text = type.ToString("G");

        frameImage.sprite = frame;
        artworkImage.sprite = artwork;
    }

    void Update()
    {
        /*
        id = displayCard[0].id;
        cardName = displayCard[0].cardName;
        cost = displayCard[0].cost;
        //power = displayCard[0].power;
        cardDescription = displayCard[0].cardDescription;
        type = displayCard[0].type;
        element = displayCard[0].element;

        nameText.text = " " + cardName;
        costText.text = " " + cost;
        //powerText.text = " " + power;
        descriptionText.text = " " + cardDescription;
        typeText.text = " " + type;
        elementText.text = " " + element;
        */

        staticCardBack = cardBack;

    }
}