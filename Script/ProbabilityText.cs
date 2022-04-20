using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProbabilityText : MonoBehaviour
{
    public Game clicked;

    public TextMeshPro probability;
    public double probabilitycount = 0.00625; 
    
    void Start()
    {
        clicked = FindObjectOfType(typeof(Game)) as Game;
        probabilitycount= 0.00625;
    }

    void Update()
    {   
        CalculateBayesianProbability(clicked.lastcheckedX, clicked.lastcheckedY, clicked.gx, clicked.gy);
        probability.text =  probabilitycount.ToString();
    }
   
   
    void CalculateBayesianProbability(int lastcheckedx, int lastcheckedy, int ghostx, int ghosty) 
    {
        probabilitycount= clicked.JointTableProbability("red", 0);

     }
}
       
    

