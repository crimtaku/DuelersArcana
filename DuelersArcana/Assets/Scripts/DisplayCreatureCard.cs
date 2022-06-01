using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DisplayCreatureCard : MonoBehaviour
{
    public CreatureCard card;

    public TMP_Text creaturePower;
    public TMP_Text creatureSpeed;
    public TMP_Text creatureHealth;

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

        creaturePower.text = card.power.ToString();
        creatureSpeed.text = card.speed.ToString();
        creatureHealth.text = card.health.ToString();

        subtypes.text = "";
        foreach (string item in card.subtypes)
        {
            subtypes.text += item + " ";
        }

        cardArt.sprite = card.cardArt;
    }
}
