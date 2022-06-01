using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DeckManager : MonoBehaviour
{
    public TMP_Text deckcount;
    public List<Card> deck=new List<Card>();

    public UIManager UIManager;


    // Start is called before the first frame update
    void Start()
    {
        deck = Suffle(deck);
        RefreshCount();
    }
    
    public void InitializeDeck(List<Card> decklist)
    {
        deck=Suffle(decklist);
        RefreshCount();
    }

    public Card DrawCard()
    {
        Card card = deck[0];
        deck.RemoveAt(0);
        RefreshCount();
        return card;
    }

    public void MillCard(int x)
    {
        for (int i=0; i<x; i++)
        {
            deck.RemoveAt(0);
        }
        RefreshCount();
    }

    public void RefreshCount()
    {
        deckcount.text = deck.Count.ToString();

        //kutsutaan metodia joka päivittää deck countin vastustajalle rpc kutsulla.
        UIManager.updateOpponentsDeckCount(deck.Count);
    }

    public List<Card> Suffle(List<Card> cards)
    {
        List<Card> shuffledDeck = new List<Card>();
        int x;
        while (cards.Count > 0)
        {
            x=Random.Range(0,cards.Count);
            shuffledDeck.Add(cards[x]);
            cards.RemoveAt(x);
        }
        return shuffledDeck;
    }
}
