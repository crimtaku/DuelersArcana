using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandManager : MonoBehaviour
{

    public List<Card> hand = new List<Card>();
    public DeckManager deckmanager;
    public List<GameObject> cardsInHand;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public void DrawCard(int x)
    {
        for(int i = 0; i < x; i++)
        {
            //Tee kutsu gamemanageriin jossa tarkistetaan mahdolliset korttiefectit

            Card newcard = deckmanager.DrawCard();
            hand.Add(newcard);
            cardsInHand.Add(Instantiate(newcard.cardprefab,this.gameObject.transform));
            
            if (newcard is CreatureCard)
            {
                cardsInHand[cardsInHand.Count - 1].GetComponent<DisplayCreatureCard>().card = (CreatureCard)newcard;
            }
            else
            {
                cardsInHand[cardsInHand.Count - 1].GetComponent<DisplayCard>().card = newcard;
            }
            
        }
    }
}
