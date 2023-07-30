using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    // This Scripts Show Text "Game Over" After Lose 
    Text Gameover;
    // Start is called before the first frame update
    void Start()
    {
        Gameover = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (NumOFTy.NumofTrys == 0)
        {
            Gameover.text = "GameOver!";
        }
    }
}
