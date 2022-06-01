using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName ="New Creature Card", menuName ="Cards/Creature")]
public class CreatureCard : Card
{
    public int power;
    public int health;
    public int speed;
    public bool taunt;
    public GameObject creaturePrefab;

    public override void OnPlay()
    {
        
    }
}
