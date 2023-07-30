using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Helth : MonoBehaviour
{
    // This Script To Mange
    public int helth;
    public int NumOfHeart;

    public Image[] Hearts;
    public Sprite FullHearts;
    public Sprite emptyheart;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        helth = NumOFTy.NumofTrys;
        if (helth>NumOfHeart)
        {
            helth = NumOfHeart;
        }
        for(int i=0; i<Hearts.Length;i++)
        {
            if(i<helth)
            {
                Hearts[i].sprite = FullHearts;
            }
            else
            {
                Hearts[i].sprite = emptyheart;

            }
            if (i<NumOfHeart)
            {
                Hearts[i].enabled = true;
            }
            else
            {
                Hearts[i].enabled = false;
            }
        }
    }
}
