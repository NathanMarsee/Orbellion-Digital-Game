using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HellionDisplay : MonoBehaviour
{
    public Hellion hellion;
    public Text nameText;
    public Text descriptionText;
    public Text healthText;
    public Text physicalText;
    public Text elementalText;

    public Image frameImage;
    public Image artworkImage;

    // Start is called before the first frame update
    void Start()
    {
        hellion = this.gameObject.GetComponent<Hellion>();
        nameText.text = hellion.name;
        descriptionText.text = hellion.passiveAbility + "\n\n" + hellion.activeAbility;

        healthText.text = "HP: " + hellion.hp.ToString();
        physicalText.text = "Physical Defense: " + hellion.physDef.ToString();
        elementalText.text = "Elemental Defense: " + hellion.elemDef.ToString();

        frameImage.sprite = Resources.Load<Sprite>(hellion.element.ToString().ToLower() + "_hellion"); 
        artworkImage.sprite = Resources.Load<Sprite>(hellion.hellName); ;
    }

}
