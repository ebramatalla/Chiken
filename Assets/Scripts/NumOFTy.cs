using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NumOFTy : MonoBehaviour
{
    public static int NumofTrys=3;
    Text Trys;

    // Start is called before the first frame update
    void Start()
    {
        Trys = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {
        Trys.text = NumofTrys.ToString();

    }
}
