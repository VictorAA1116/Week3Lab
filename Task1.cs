using UnityEngine;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Task1 : MonoBehaviour
{
    public string classname = "Math Class";
    public int factor1 = 0;
    public int factor2 = 0;
    public int factor3 = 0;
    public int factor4 = 0;
    public int factor5 = 0;

    public int challengescore = 0;

    // Start is called before the first frame update
    void Start()
    {
        challengescore = (factor1 + factor2 + factor3 + factor4 + factor5) / 10;
        Debug.Log($"The class {classname} has a challenge score of:{challengescore}");

    }

    // Update is called once per frame
    void Update()
    {

    }
}