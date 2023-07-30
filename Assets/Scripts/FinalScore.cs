using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalScore : MonoBehaviour
{
    // This Script Show Final Score After Lose
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (NumOFTy.NumofTrys == 0)
        {
            score.text = CScore.curscore.ToString();
        }

    }
}
