using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HellionDisplay : MonoBehaviour
{
    public HellionScript hellion;
    public Text nameText;
    public Text passiveText;
    public Text activeText;
    public Text healthText;
    public Text physicalText;
    public Text elementalText;

    public Image frameImage;
    public Image artworkImage;

    // Start is called before the first frame update
    void Start()
    {
        nameText.text = hellion.name;
        passiveText.text = hellion.passive;
        activeText.text = "Active: " + hellion.active;

        healthText.text = "HP: " + hellion.health.ToString();
        physicalText.text = "Physical Defense: " + hellion.physicalDef.ToString();
        elementalText.text = "Elemental Defense: " + hellion.elementalDef.ToString();

        frameImage.sprite = hellion.frame;
        artworkImage.sprite = hellion.artwork;
    }

}
