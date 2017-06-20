using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IconController : MonoBehaviour {

    public Text textBalance;
    public Text textHP;
    public Text textKills;

    private const int maxBalance = 1000;

    private int kills = 0;
    private int HP = 10;
    private int balance = 0;
    

    // Use this for initialization
    void Start()
    {
        textBalance.text = "$: " + balance;
        textKills.text = "Kills: " + kills;
        textHP.text = "HP: " + HP;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void IncreaseBalance()
    {
        if (balance < maxBalance)
            balance += 10;

        if (balance > 999)
            textBalance.fontSize = 25;
        else if (balance > 99)
            textBalance.fontSize = 35;

        textBalance.text = "$: " + balance;
    }

    public void IncreaseKills()
    {
        kills++;

        if (kills > 99)
            textKills.fontSize = 25;
        else if (kills > 9)
            textKills.fontSize = 30;

        textKills.text = "Kills: " + kills;
    }

    public void TakeDamange()
    {
        HP--;

        textHP.text = "HP: " + HP;
    }
}
