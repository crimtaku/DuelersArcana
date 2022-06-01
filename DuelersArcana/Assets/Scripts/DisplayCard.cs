using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayCard : MonoBehaviour
{

    public Card card;
    public TMP_Text cardName;
    public TMP_Text cardText;
    public TMP_Text manaCost;
    public TMP_Text subtypes;

    public Image border;
    public Image cardArt;


    private void Start()
    {
        UpdateCardData();
    }

    public void UpdateCardData()
    {
        cardName.text = card.cardName;
        cardText.text = card.description;
        manaCost.text = card.cost.ToString();

        subtypes.text = "";
        foreach(string item in card.subtypes)
        {
            subtypes.text += item + " ";
        }
        
        cardArt.sprite = card.cardArt;
    }
    
}
