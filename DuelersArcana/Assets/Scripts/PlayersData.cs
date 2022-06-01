using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayersData : MonoBehaviour
{

    public int playerMP;
    public int playerActions;
    public int maxHandSize;

    public UIManager uIManager;

    // Start is called before the first frame update
    void Start()
    {
        uIManager = this.gameObject.GetComponent<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddActions(int amount)
    {
        playerActions += amount;
        uIManager.updateActions(playerActions);
    }

    public void AddMP(int amount)
    {
        playerMP += amount;
        uIManager.updateMP(playerMP);
    }
}
