using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CardDisplay : MonoBehaviour
{

    public CardScript card;
    public Text nameText;
    public Text descriptionText;
    public Text energyCostText;
    public Text typeText;

    public Image frameImage;
    public Image artworkImage;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = card.name;
        descriptionText.text = card.description;
        typeText.text = card.type;

        energyCostText.text = card.energyCost.ToString();

        frameImage.sprite = card.frame;
        artworkImage.sprite = card.artwork;
    }

}
