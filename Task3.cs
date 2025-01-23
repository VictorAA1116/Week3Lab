using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task3 : MonoBehaviour
{
    //Set initial components
    public int TotalPaid = 0;
    int leftover = 0;
    int hun = 0;
    int fif = 0;
    int twen = 0;
    int ten = 0;
    int five = 0;
    int one = 0;


    // Start is called before the first frame update
    void Start()
    {
        //Set the equation for each individual bill with total amount being paid and the left over value
        hun = TotalPaid / 100;
        leftover = TotalPaid % 100;

        fif = leftover / 50;
        leftover = leftover % 50;

        twen = leftover / 20;
        leftover = leftover % 20;

        ten = leftover / 10;
        leftover = leftover % 10;

        five = leftover / 5;
        leftover = leftover % 5;

        one = leftover / 1;
        leftover = leftover % 1;


        Debug.Log($"Bill Type Recieved, Hundred:{hun} Fifty:{fif} Twenty:{twen} Ten:{ten} Five:{five} One: {one}");


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
