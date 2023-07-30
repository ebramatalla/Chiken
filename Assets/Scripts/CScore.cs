using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CScore : MonoBehaviour

{
    // This Scripts Show Score While Playing
    public static int curscore=0 ;
    Text scoree;
    

    // Start is called before the first frame update
    void Start()
    {
        scoree = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
      
        scoree.text =  curscore.ToString();


    }
}