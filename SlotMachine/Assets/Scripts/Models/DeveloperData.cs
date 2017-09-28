using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DeveloperData : MonoBehaviour {

    public GameObject objectOfItSelf;

    public int NumberOfSpins = 0;
    public float OverAllWon = 0;
    public float OverAllLost = 0;
    public float RTP = 100;

    public Text NumberOfSpinsText;
    public Text OverAllWonText;
    public Text OverAllLostText;
    public Text RTPText;

    public int TimesWonSymbol01 = 0;
    public int TimesWonSymbol02 = 0;
    public int TimesWonSymbol03 = 0;
    public int TimesWonSymbol04 = 0;
    public int TimesWonSymbol05 = 0;
    public int TimesWonSymbol06 = 0;
    public int TimesWonSymbol07 = 0;
    public int TimesWonSymbol08 = 0;
    public int TimesWonSymbol09 = 0;
    public int TimesWonSymbol10 = 0;
    public int TimesWonSymbol11 = 0;
    public int TimesWonSymbol12 = 0;

    public Text TimesWonSymbol01Text;
    public Text TimesWonSymbol02Text;
    public Text TimesWonSymbol03Text;
    public Text TimesWonSymbol04Text;
    public Text TimesWonSymbol05Text;
    public Text TimesWonSymbol06Text;
    public Text TimesWonSymbol07Text;
    public Text TimesWonSymbol08Text;
    public Text TimesWonSymbol09Text;
    public Text TimesWonSymbol10Text;
    public Text TimesWonSymbol11Text;
    public Text TimesWonSymbol12Text;



    public void IncreaseNumberOfSpins()
    {
        NumberOfSpins = NumberOfSpins + 1;
    }

    public void DecreaseOverAllLost()
    {
        OverAllLost = OverAllLost + 1;

    }

    public void NewOverAllWon(int AddWon)
    {
        OverAllWon = OverAllWon + AddWon;

    }

    public void SymbolWin(int symbolNumber)
    {
        if (symbolNumber == 1) { TimesWonSymbol01 += 1; }
        if (symbolNumber == 2) { TimesWonSymbol02 += 1; }
        if (symbolNumber == 3) { TimesWonSymbol03 += 1; }
        if (symbolNumber == 4) { TimesWonSymbol04 += 1; }
        if (symbolNumber == 5) { TimesWonSymbol05 += 1; }
        if (symbolNumber == 6) { TimesWonSymbol06 += 1; }
        if (symbolNumber == 7) { TimesWonSymbol07 += 1; }
        if (symbolNumber == 8) { TimesWonSymbol08 += 1; }
        if (symbolNumber == 9) { TimesWonSymbol09 += 1; }
        if (symbolNumber == 10) { TimesWonSymbol10 += 1; }
        if (symbolNumber == 11) { TimesWonSymbol11 += 1; }
        if (symbolNumber == 12) { TimesWonSymbol12 += 1; }
    }
    // Use this for initialization
    void Start () {
        


    }
	
	// Update is called once per frame
	void Update () {

        //Update of Number Of spins text
        NumberOfSpinsText.text = NumberOfSpins.ToString();

        OverAllLostText.text = OverAllLost.ToString();
        OverAllWonText.text = OverAllWon.ToString();
        RTPText.text = ((OverAllWon / OverAllLost)*100).ToString("F1") + "%";

        //Update how many times there have been a win on every symbol
        TimesWonSymbol01Text.text = TimesWonSymbol01.ToString();
        TimesWonSymbol02Text.text = TimesWonSymbol02.ToString();
        TimesWonSymbol03Text.text = TimesWonSymbol03.ToString();
        TimesWonSymbol04Text.text = TimesWonSymbol04.ToString();
        TimesWonSymbol05Text.text = TimesWonSymbol05.ToString();
        TimesWonSymbol06Text.text = TimesWonSymbol06.ToString();
        TimesWonSymbol07Text.text = TimesWonSymbol07.ToString();
        TimesWonSymbol08Text.text = TimesWonSymbol08.ToString();
        TimesWonSymbol09Text.text = TimesWonSymbol09.ToString();
        TimesWonSymbol10Text.text = TimesWonSymbol10.ToString();
        TimesWonSymbol11Text.text = TimesWonSymbol11.ToString();
        TimesWonSymbol12Text.text = TimesWonSymbol12.ToString();



    }
}
