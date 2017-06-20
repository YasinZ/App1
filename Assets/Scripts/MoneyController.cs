using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyController : MonoBehaviour {

    public Text text;
    private int balance = 0;
    private const int maxBalance = 10000;

	// Use this for initialization
	void Start () {
        text.text = "$: " + balance;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void IncreaseBalance()
    {
        if(balance < maxBalance)
            balance += 10;

        text.text = "$: " + balance;
    }
}
