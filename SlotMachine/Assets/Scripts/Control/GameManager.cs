using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{
    public AudioClip smallWin;
    public AudioClip mediumWin;
    public AudioClip bigWin;
    public AudioClip spinning;
    public AudioSource audioSorce;

    public GameObject particlePrefab;
    public GameObject coinPrefab;

    public float time = 0;
    private float spinningTime = 1.1f;

    //To spawn coins corresponding to the last given reward
    public int lastGivenReward = 0;

    //Brick Images
    public Image spot1;
    public Image spot2;
    public Image spot3;
    public Image spot4;
    public Image spot5;
    public Image spot6;
    public Image spot7;
    public Image spot8;
    public Image spot9;

    
    //Bricks holders
    public Brick brick1;
    public Brick brick2;
    public Brick brick3;
    public Brick brick4;
    public Brick brick5;
    public Brick brick6;
    public Brick brick7;
    public Brick brick8;
    public Brick brick9;
    public Brick brick10;
    public Brick brick11;
    public Brick brick12;


    public Brick[] places = new Brick[9];

    public Brick place1;
    public Brick place2;
    public Brick place3;
    public Brick place4;
    public Brick place5;
    public Brick place6;
    public Brick place7;
    public Brick place8;
    public Brick place9;


    public Brick[] brickArray = new Brick[30];


    public GameObject RandomNrGen;
    public GameObject KreditGui;
    public GameObject GameDeveloperData;
    

    //GUI
    public Text KreditAmount;
    public Text PanalWalletAmount;
    public Text PanelKreditAmount;
    public Image Panel;
    public Image DevPanel;
    public Button SpinButton;
    public Button AutoSpinning;
    public Button StopAutoSpinning;
    public Image coinImage;
    

    public int a1NewSpin { get; set; }
    public int b1NewSpin { get; set; }
    public int c1NewSpin { get; set; }
    public int a2NewSpin { get; set; }
    public int b2NewSpin { get; set; }
    public int c2NewSpin { get; set; }
    public int a3NewSpin { get; set; }
    public int b3NewSpin { get; set; }
    public int c3NewSpin { get; set; }

    public int KreditWin01 = 3;
    public int KreditWin02 = 6;
    public int KreditWin03 = 10;
    public int KreditWin04 = 15;
    public int KreditWin05 = 25;
    public int KreditWin06 = 40;
    public int KreditWin07 = 65;
    public int KreditWin08 = 90;
    public int KreditWin09 = 130;
    public int KreditWin10 = 180;
    public int KreditWin11 = 200;
    public int KreditWin12 = 300;

    //The 9 slots in the wheel, where 1,2,3 goes vertical and a,b,c horzontial

    private void Awake()
    {

        brick1 = new Brick() { BrickType = BrickType.One, Sprite = Resources.Load<Sprite>("symbol01") };
        brick2 = new Brick() { BrickType = BrickType.Two, Sprite = Resources.Load<Sprite>("symbol02") };
        brick3 = new Brick() { BrickType = BrickType.Three, Sprite = Resources.Load<Sprite>("symbol03") };
        brick4 = new Brick() { BrickType = BrickType.Four, Sprite = Resources.Load<Sprite>("symbol04") };
        brick5 = new Brick() { BrickType = BrickType.Five, Sprite = Resources.Load<Sprite>("symbol05") };
        brick6 = new Brick() { BrickType = BrickType.Six, Sprite = Resources.Load<Sprite>("symbol06") };
        brick7 = new Brick() { BrickType = BrickType.Seven, Sprite = Resources.Load<Sprite>("symbol07") };
        brick8 = new Brick() { BrickType = BrickType.Eight, Sprite = Resources.Load<Sprite>("symbol08") };
        brick9 = new Brick() { BrickType = BrickType.Nine, Sprite = Resources.Load<Sprite>("symbol09") };
        brick10 = new Brick() { BrickType = BrickType.Ten, Sprite = Resources.Load<Sprite>("symbol10") };
        brick11 = new Brick() { BrickType = BrickType.Eleven, Sprite = Resources.Load<Sprite>("symbol11") };
        brick12 = new Brick() { BrickType = BrickType.Twelve, Sprite = Resources.Load<Sprite>("symbol12") };





        brickArray[0] = brick1;
        brickArray[1] = brick2;
        brickArray[2] = brick3;
        brickArray[3] = brick4;
        brickArray[4] = brick5;
        brickArray[5] = brick6;
        brickArray[6] = brick7;
        brickArray[7] = brick8;
        brickArray[8] = brick9;
        brickArray[9] = brick10;
        brickArray[10] = brick11;
        brickArray[11] = brick12;
        brickArray[12] = brick1;
        brickArray[13] = brick1;
        brickArray[14] = brick1;
        brickArray[15] = brick1;
        brickArray[16] = brick2;
        brickArray[17] = brick2;
        brickArray[18] = brick2;
        brickArray[19] = brick3;
        brickArray[20] = brick3;
        brickArray[21] = brick4;
        brickArray[22] = brick4;
        brickArray[23] = brick5;
        brickArray[24] = brick5;
        brickArray[25] = brick6;
        brickArray[26] = brick7;
        brickArray[27] = brick8;
        brickArray[28] = brick9;
        brickArray[29] = brick10;
       

    }
    // Use this for initialization
    void Start () {





        
    }

    //Move this method to GUI script
    public void OpenWalletPanel()
    {
        Panel.gameObject.SetActive(true);
    }

    public void CloseWalletPanel()
    {
        Panel.gameObject.SetActive(false);
    }
    public void OpenDeveloperPanel()
    {
        DevPanel.gameObject.SetActive(true);
    }

    public void CloseDeveloperPanel()
    {
        DevPanel.gameObject.SetActive(false);
    }
    private void FixedUpdate()
    {
        //Set Kredits into text on GUI - MAKE A GUI SCRIPT FOR THIS
        int curKredits = KreditGui.GetComponent<KreditModel>().Kredits;
        KreditAmount.text = curKredits.ToString();

        //Set Money into Text on GUI Panel - MAKE A GUI SCRIPT FOR THIS
        double curMoney = KreditGui.GetComponent<KreditModel>().Money;
        PanalWalletAmount.text = curMoney.ToString();

        //Set Kredits into text on GUI Panel - MAKE A GUI SCRIPT FOR THIS
        int curPanKredits = KreditGui.GetComponent<KreditModel>().Kredits;
        PanelKreditAmount.text = curPanKredits.ToString();
    }
    // Update is called once per frame
    void Update () {
        //Get random numbers
        a1NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().a1;
        b1NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().b1;
        c1NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().c1;

        a2NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().a2;
        b2NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().b2;
        c2NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().c2;

        a3NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().a3;
        b3NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().b3;
        c3NewSpin = RandomNrGen.GetComponent<RandomNumberGenerator>().c3;
    }

    public void AutoSpin()
    {
        AutoSpinning.gameObject.SetActive(false);
        StopAutoSpinning.gameObject.SetActive(true);
        if (KreditGui.GetComponent<KreditModel>().Kredits > 0)
        {
            InvokeRepeating("Spin", Time.deltaTime, 2.5f);
        }
            
        //float AutoSpinningTime = 5f;
       // while (time < AutoSpinningTime)
      //  {
        //    StartCoroutine(Wait(2000f));
       //     time += Time.deltaTime;
        //    Spin();
        //    Debug.Log(time);
      //  }
      //  time = 0f;

        //   float nextActionTime = 0.0f;
        //float period = 1.5f;
        //
        // {
        //     if (Time.time > nextActionTime)
        //   {
        //        nextActionTime = Time.time + period;
        //   }
        //AutoSpinning.gameObject.SetActive(false);
        // autoSpinning = true;
        // while ( KreditModel.GetComponent<KreditModel>().Kredits > 0)
        //  {
        //
        //     Spin();
        //     System.Threading.Thread.Sleep(1000);

        //  }
    }

    public void StopAutoSpin()
    {
        AutoSpinning.gameObject.SetActive(true);
        StopAutoSpinning.gameObject.SetActive(false);
        CancelInvoke();

    }
    public void Spin()
    {

        DestroyPreviousCoins();

        //Remove Spin button will spinning
        SpinButton.gameObject.SetActive(false);

        //Count 1 up in the "Number of spins" in the developer data
        GameDeveloperData.GetComponent<DeveloperData>().IncreaseNumberOfSpins();
        //Count 1 up in the "Over All Lost" in the developer data
        GameDeveloperData.GetComponent<DeveloperData>().DecreaseOverAllLost();

        if (KreditGui.GetComponent<KreditModel>().Kredits > 0)
        {
            //Remove 1 kredit
            KreditGui.GetComponent<KreditModel>().Kredits = KreditGui.GetComponent<KreditModel>().Kredits - 1;

            StartCoroutine("ResetItween");
            ResetParticles();

            audioSorce.clip = spinning;
            audioSorce.Play();

            StartCoroutine(SetBricks());
        }
        else
        {
            //Make A method in GUI script for this
            SpinButton.gameObject.SetActive(true);
        }

        //StartCoroutine(SetBrick(place1, 0, spot1, 1f));
        //StartCoroutine(SetBrick(place2, b1NewSpin, 1, spot2, 2f));
        //StartCoroutine(SetBrick(place3, c1NewSpin, 2, spot3, 3f));
        //StartCoroutine(SpinningAnimation());

        //iTween.ShakePosition(spot1.GetComponent<RectTransform>().gameObject, new Vector3(2f, 2f, 2f), 0.8f);
        //iTween.ShakeRotation(spot1.GetComponent<RectTransform>().gameObject, new Vector3(2f, 2f, 2f), 0.8f);
        //iTween.ScaleBy(spot1.GetComponent<RectTransform>().gameObject, iTween.Hash("x", 1.1f, "y", 1.1f, "time", 0.5f,"easetype", iTween.EaseType.easeInElastic, "looptype", iTween.LoopType.pingPong));
        //Get random numbers

        //Debug.Log(a1NewSpin);
        //Debug.Log(b1NewSpin);
        //Debug.Log(c1NewSpin);

        //Debug.Log(a2NewSpin);
        //Debug.Log(b2NewSpin);
        //Debug.Log(c2NewSpin);

        //Debug.Log(a3NewSpin);
        //Debug.Log(b3NewSpin);
        //Debug.Log(c3NewSpin);
    }

    private IEnumerator SetBrick(Brick place, int placesIndex, Image spot, float brickSpinTime)
    {

        while (time < brickSpinTime)
        {
            Debug.Log(a1NewSpin);
            time += Time.deltaTime;

            place = brickArray[a1NewSpin - 1];
            places[placesIndex] = place;
            spot.sprite = place.Sprite;

            yield return null;
        }
        //DidIWin(places);
        time = 0f;
    }

    private IEnumerator SetBricks()
    {
        while (time < spinningTime)
        {
            //Debug.Log("hahahah");
            time += Time.deltaTime;

            //Asign bricks to placeholders, based on random number
            place1 = brickArray[a1NewSpin - 1];
            place2 = brickArray[b1NewSpin - 1];
            place3 = brickArray[c1NewSpin - 1];

            place4 = brickArray[a2NewSpin - 1];
            place5 = brickArray[b2NewSpin - 1];
            place6 = brickArray[c2NewSpin - 1];

            place7 = brickArray[a3NewSpin - 1];
            place8 = brickArray[b3NewSpin - 1];
            place9 = brickArray[c3NewSpin - 1];

            //Hack to win
              //   place1 = brickArray[11];
                //place2 = brickArray[11];
               // place3 = brickArray[11];

            places[0] = place1;
            places[1] = place2;
            places[2] = place3;
            places[3] = place4;
            places[4] = place5;
            places[5] = place6;
            places[6] = place7;
            places[7] = place8;
            places[8] = place9;

            //Debug.Log("Brick type plads 1: " + places[0].BrickType);
            //Assign sprites to UI
      
            spot1.sprite = place1.Sprite;
            spot2.sprite = place2.Sprite;
            spot3.sprite = place3.Sprite;

            spot4.sprite = place4.Sprite;
            spot5.sprite = place5.Sprite;
            spot6.sprite = place6.Sprite;

            spot7.sprite = place7.Sprite;
            spot8.sprite = place8.Sprite;
            spot9.sprite = place9.Sprite;

            yield return null;
        }

        DidIWin(places);
        SpinButton.gameObject.SetActive(true);
        time = 0f;
    }

    private IEnumerator SpinningAnimation()
    {
        
        while (time < spinningTime)
        {
            
            time += Time.deltaTime;
            Debug.Log("hej");

            yield return null;
        }
        

    }

    private void ResetParticles()
    {
        var Particles = GameObject.FindGameObjectsWithTag("Particle");
        for (int i = 0; i < Particles.Length; i++)
        {
            Destroy(Particles[i]);
        }
    }

    private void ResetItween()
    {
        //yield return new WaitForSeconds(0.5f);
        ResetAnimations(spot1);
        ResetAnimations(spot2);
        ResetAnimations(spot3);
        ResetAnimations(spot4);
        ResetAnimations(spot5);
        ResetAnimations(spot6);
        ResetAnimations(spot7);
        ResetAnimations(spot8);
        ResetAnimations(spot9);

    }

    private void ResetAnimations(Image obj)
    {
        iTween.Stop(obj.GetComponent<RectTransform>().gameObject);
        obj.GetComponent<RectTransform>().localScale = new Vector3(1, 1, 1);
    }

    private void WinAnimation(Image image)
    {
        iTween.ScaleBy(image.GetComponent<RectTransform>().gameObject, iTween.Hash("x", 1.1f, "y", 1.1f, "time", 0.3f, "easetype", iTween.EaseType.linear, "looptype", iTween.LoopType.pingPong));

    }
    private void DidIWin(Brick[] places)
    {
        bool didIWin = false;

        if (places[0].BrickType == places[1].BrickType && places[1].BrickType == places[2].BrickType)
        {

            GiveReward(0, 1, 2);
            Debug.Log("Du vandt med plads 1 - 2 - 3");
            WinAnimation(spot1);
            WinAnimation(spot2);
            WinAnimation(spot3);
            SpawnParticle(spot1);
            SpawnParticle(spot2);
            SpawnParticle(spot3);
            SpawnCoins(spot1);
            SpawnCoins(spot2);
            SpawnCoins(spot3);
            didIWin = true;

        }
        if (places[3].BrickType == places[4].BrickType && places[4].BrickType == places[5].BrickType)
        {
            GiveReward(3, 4, 5);
            Debug.Log("Du vandt med plads 4 - 5 - 6");
            WinAnimation(spot4);
            WinAnimation(spot5);
            WinAnimation(spot6);
            SpawnParticle(spot4);
            SpawnParticle(spot5);
            SpawnParticle(spot6);
            SpawnCoins(spot4);
            SpawnCoins(spot5);
            SpawnCoins(spot6);
            didIWin = true;
        }
        if (places[6].BrickType == places[7].BrickType && places[7].BrickType == places[8].BrickType)
        {
            GiveReward(6, 7, 8);
            Debug.Log("Du vandt med plads 7 - 8 - 9");
            WinAnimation(spot7);
            WinAnimation(spot8);
            WinAnimation(spot9);
            SpawnParticle(spot7);
            SpawnParticle(spot8);
            SpawnParticle(spot9);
            SpawnCoins(spot7);
            SpawnCoins(spot8);
            SpawnCoins(spot9);
            didIWin = true;
        }
        if (places[0].BrickType == places[3].BrickType && places[3].BrickType == places[6].BrickType)
        {
            GiveReward(0, 3, 6);
            Debug.Log("Du vandt med plads 1 - 4 - 7");
            WinAnimation(spot1);
            WinAnimation(spot4);
            WinAnimation(spot7);
            SpawnParticle(spot1);
            SpawnParticle(spot4);
            SpawnParticle(spot7);
            SpawnCoins(spot1);
            SpawnCoins(spot4);
            SpawnCoins(spot7);
            didIWin = true;
        }
        if (places[1].BrickType == places[4].BrickType && places[4].BrickType == places[7].BrickType)
        {
            GiveReward(1, 4, 7);
            Debug.Log("Du vandt med plads 2 - 5 - 8");
            WinAnimation(spot2);
            WinAnimation(spot5);
            WinAnimation(spot8);
            SpawnParticle(spot2);
            SpawnParticle(spot5);
            SpawnParticle(spot8);
            SpawnCoins(spot2);
            SpawnCoins(spot5);
            SpawnCoins(spot8);
            didIWin = true;
        }
        if (places[2].BrickType == places[5].BrickType && places[5].BrickType == places[8].BrickType)
        {
            GiveReward(2,5,8);
            Debug.Log("Du vandt med plads 3 - 6 - 9");
            WinAnimation(spot3);
            WinAnimation(spot6);
            WinAnimation(spot9);
            SpawnParticle(spot3);
            SpawnParticle(spot6);
            SpawnParticle(spot9);
            SpawnCoins(spot3);
            SpawnCoins(spot6);
            SpawnCoins(spot9);
            didIWin = true;
        }
        if(didIWin == true)
        {
            audioSorce.clip = smallWin;
            audioSorce.Play();

        }
    }

    private void GiveReward(int place1, int place2, int place3)
    {

        //Check what kind of brick what match, so a reward can be given
        if (places[place1].BrickType == BrickType.One && places[place2].BrickType == BrickType.One && places[place3].BrickType == BrickType.One)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin01);
            lastGivenReward = KreditWin01;


            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin01);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(1);

        }
        if (places[place1].BrickType == BrickType.Two && places[place2].BrickType == BrickType.Two && places[place3].BrickType == BrickType.Two)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin02);
            lastGivenReward = KreditWin02;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin02);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(2);
        }
        if (places[place1].BrickType == BrickType.Three && places[place2].BrickType == BrickType.Three && places[place3].BrickType == BrickType.Three)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin03);
            lastGivenReward = KreditWin03;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin03);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(3);
        }
        if (places[place1].BrickType == BrickType.Four && places[place2].BrickType == BrickType.Four && places[place3].BrickType == BrickType.Four)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin04);
            lastGivenReward = KreditWin04;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin04);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(4);
        }
        if (places[place1].BrickType == BrickType.Five && places[place2].BrickType == BrickType.Five && places[place3].BrickType == BrickType.Five)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin05);
            lastGivenReward = KreditWin05;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin05);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(5);
        }
        if (places[place1].BrickType == BrickType.Six && places[place2].BrickType == BrickType.Six && places[place3].BrickType == BrickType.Six)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin06);
            lastGivenReward = KreditWin06;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin06);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(6);
        }
        if (places[place1].BrickType == BrickType.Seven && places[place2].BrickType == BrickType.Seven && places[place3].BrickType == BrickType.Seven)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin07);
            lastGivenReward = KreditWin07;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin07);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(7);
        }
        if (places[place1].BrickType == BrickType.Eight && places[place2].BrickType == BrickType.Eight && places[place3].BrickType == BrickType.Eight)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin08);
            lastGivenReward = KreditWin08;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin08);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(8);
        }
        if (places[place1].BrickType == BrickType.Nine && places[place2].BrickType == BrickType.Nine && places[place3].BrickType == BrickType.Nine)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin09);
            lastGivenReward = KreditWin09;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin09);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(9);
        }
        if (places[place1].BrickType == BrickType.Ten && places[place2].BrickType == BrickType.Ten && places[place3].BrickType == BrickType.Ten)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin10);
            lastGivenReward = KreditWin10;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin10);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(10);
        }
        if (places[place1].BrickType == BrickType.Eleven && places[place2].BrickType == BrickType.Eleven && places[place3].BrickType == BrickType.Eleven)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin11);
            lastGivenReward = KreditWin11;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin11);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(11);
        }
        if (places[place1].BrickType == BrickType.Twelve && places[place2].BrickType == BrickType.Twelve && places[place3].BrickType == BrickType.Twelve)
        {
            KreditGui.GetComponent<KreditControl>().GiveKredits(KreditWin12);
            lastGivenReward = KreditWin12;

            //Add win amount to "Over All Win" in developmer data
            GameDeveloperData.GetComponent<DeveloperData>().NewOverAllWon(KreditWin12);
            GameDeveloperData.GetComponent<DeveloperData>().SymbolWin(12);
        }
    }

    private void SpawnParticle(Image spot)
    {
        Instantiate(particlePrefab, spot.GetComponent<RectTransform>().gameObject.transform.position, Quaternion.Euler(-180,0 , 0));
    }

    public void SpawnCoins(Image spot)
    {
        

        int coinCounter = 0;
        while (coinCounter < lastGivenReward)
        {
            Vector3 coinSpawnPos = spot.GetComponent<RectTransform>().gameObject.transform.position;
            coinSpawnPos = coinSpawnPos + new Vector3(UnityEngine.Random.Range(-75, 75), UnityEngine.Random.Range(-75, 75), -1);
            GameObject newCoinObj = Instantiate(coinPrefab, coinSpawnPos, Quaternion.Euler(-90, 0, 0));
            Vector3 coinEndPosition = coinImage.transform.position;
            iTween.MoveTo(newCoinObj, iTween.Hash("position", coinEndPosition, "easetype", iTween.EaseType.easeInQuad, "time" , 1f));
            
            coinCounter = coinCounter + 10;
        }
    }

    private void DestroyPreviousCoins()
    {
        GameObject[] ObjectsToDestroy = GameObject.FindGameObjectsWithTag("CoinTag");
        foreach (GameObject go in ObjectsToDestroy)
            Destroy(go);
    }

    IEnumerator Wait(float secounds)
    {
        yield return new WaitForSeconds(secounds);
    }
}
