using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public abstract class Card:ScriptableObject
{
    public int id;
    public string cardName;

    public GameObject cardprefab;
    
    [TextArea(2,10)]
    public string description;
    public int cost;
    public string[] subtypes;

    public Sprite cardArt;

    abstract public void OnPlay();
    

    /*
    public Card()
    {

    }

    public Card(int Id, string Name, int Cost, string Description, string[] Subtypes, Sprite Artwork)
    {
        id = Id;
        cardName = Name;
        description = Description;
        cost= Cost;
        cardArt = Artwork;
        subtypes = Subtypes;
    }*/
   
}
