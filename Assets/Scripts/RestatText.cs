using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RestatText : MonoBehaviour
{
    // this script To Restart Game
    Text Restart;

    // Start is called before the first frame update
    void Start()
    {
        Restart = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        if (NumOFTy.NumofTrys == 0)
        {
            Restart.text = "Press To Restart";
        }
    }
}

