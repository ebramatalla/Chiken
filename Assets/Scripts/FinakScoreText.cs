using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinakScoreText : MonoBehaviour
{
    // This Scripts Show Text "Your Score " After Lose
    Text FScore;

    // Start is called before the first frame update
    void Start()
    {
        FScore = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (NumOFTy.NumofTrys == 0)
        {
            FScore.text = "Your Score!";
        }

    }
}
