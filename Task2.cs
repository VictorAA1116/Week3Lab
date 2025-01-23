using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEditor.Profiling;
using UnityEngine;

public class script : MonoBehaviour
{
    public float bookPrice = 0;
    public int booksSold = 0;
    float profit = 0;
    float cost = 0;


    // Start is called before the first frame update
    void Start()
    {
        profit = (float)((bookPrice * booksSold) * 0.6 - ((booksSold - 1) * 0.75) - 3);
        cost = bookPrice * booksSold - profit;

        Debug.Log($"Profit is {profit} and cost is {cost}");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
