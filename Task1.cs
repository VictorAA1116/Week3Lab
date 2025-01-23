using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class Task1 : MonoBehaviour
{
    //Factors are for the different percent catagories
    public string classname = "Math Clas";
    public int factor1 = 0;
    public int factor2 = 0;
    public int factor3 = 0;
    public int factor4 = 0;
    public int factor5 = 0;

    public int challengescore = 0;

    //calculate challenge score
  



  
    // Start is called before the first frame update
    void Start()
    {
        //Equation to find the total score
        challengescore = (factor1 + factor2  + factor3 + factor4 + factor5)/10;
        Debug.Log($"The class {classname} has a challenge score of:{challengescore}");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
