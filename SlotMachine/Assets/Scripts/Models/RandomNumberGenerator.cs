using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomNumberGenerator : MonoBehaviour
{
    
    //The 9 slots in the wheel, where 1,2,3 goes vertical and a,b,c horzontial
    public int a1 { get; private set; }
    public int b1 { get; private set; }
    public int c1 { get; private set; }
    public int a2 { get; private set; }
    public int b2 { get; private set; }
    public int c2 { get; private set; }
    public int a3 { get; private set; }
    public int b3 { get; private set; }
    public int c3 { get; private set; }


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        a1 = GenerateRandomNumber();
        b1 = GenerateRandomNumber();
        c1 = GenerateRandomNumber();
        a2 = GenerateRandomNumber();
        b2 = GenerateRandomNumber();
        c2 = GenerateRandomNumber();
        a3 = GenerateRandomNumber();
        b3 = GenerateRandomNumber();
        c3 = GenerateRandomNumber();
    }

    public int GenerateRandomNumber()
    {
        int intToRandom = UnityEngine.Random.Range(1, 31);
        return intToRandom;
    }

}
