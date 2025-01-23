using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Task2 : MonoBehaviour
{

    //name components
    // X value = bookprice
    // Y value = bookcount
    public float bookprice = 0;
    public int bookcount = 0;
    float profit = 0;
    float cost = 0;
  
    
    // Start is called before the first frame update
    void Start()
    {
        //calculate total
        profit = (float)((bookprice * bookcount) * 0.6 - (bookcount- 1) * 0.75) -3;
        cost = bookprice * bookcount - profit;

        Debug.Log($"Profit total is {profit} and the is {cost}");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
