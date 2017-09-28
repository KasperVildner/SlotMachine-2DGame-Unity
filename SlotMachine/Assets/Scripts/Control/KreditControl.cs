using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KreditControl : MonoBehaviour {

    public GameObject kreditModel;

    public void GiveKredits(int amountToGive)
    {
        kreditModel.GetComponent<KreditModel>().Kredits = kreditModel.GetComponent<KreditModel>().Kredits + amountToGive;
    }

    void setMoney()
    {
      
    }

    void BuyKredits(double AmountOfMoneyIntoKredits)
    {

    }

    void WidthdrawKredits()
    {

    }


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
