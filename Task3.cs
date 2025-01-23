using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    public int dollarsPaid = 0;
    int dollarsLeft = 0;
    int hundreds = 0;
    int fifties = 0;
    int twenties = 0;
    int tens = 0;
    int fives = 0;
    int ones = 0;


    // Start is called before the first frame update
    void Start()
    {
        hundreds = dollarsPaid / 100;
        dollarsLeft = dollarsPaid % 100;
        fifties = dollarsLeft / 50;
        dollarsLeft = dollarsLeft % 50;
        twenties = dollarsLeft / 20;
        dollarsLeft = dollarsLeft % 20;
        tens = dollarsLeft / 10;
        dollarsLeft = dollarsLeft % 10;
        fives = dollarsLeft / 5;
        dollarsLeft = dollarsLeft % 5;
        ones = dollarsLeft / 1;

        Debug.Log($"You will be paid with {hundreds} hundreds, {fifties} fifties, {twenties} twenties, {tens} tens, {fives} fives, {ones} ones");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
