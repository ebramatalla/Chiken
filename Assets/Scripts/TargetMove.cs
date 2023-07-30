using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetMove : MonoBehaviour
{
    // Varible 
    [HideInInspector]
    public Vector3 Move = new Vector3(-0.5f, 0, 0);
    public Vector3 MoveRot = new Vector3(-0, 0, 0.5f);
    public float Speed = 25;
    public float RotSpeed = 150;
    public Vector3 Fristpos;
    // Start is called before the first frame update
    void Start()
    {
        Fristpos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        // Make Chiken Move To Right 
        transform.position += Move*Speed*Time.deltaTime;
        // if chiken Move Out From The scene Return it From The Another Side
        if (transform.position.x > (KnifeShot.XValue+1f))
        {
            transform.position = new Vector3(-KnifeShot.XValue-1f, transform.position.y, transform.position.z);
        }
        // If chiken Get Hit Make it Drop 
        if(KnifeShot.Hit)
        {
                transform.position += Vector3.down*0.1f;

        }
        // If Get Out Of Scene After Hit return It  And  Make It Faster
        if (transform.position.y < -KnifeShot.YValue &&KnifeShot.Hit)
        {
            Speed += 5;
            RotSpeed+=5;
            transform.position = new Vector3(-KnifeShot.XValue - 1f, 3.5f, transform.position.z);
            KnifeShot.Hit = false;
        }
        // If Lose Make Ckiken In Frist Pos And Stop Rotation
        if (KnifeShot.lose)
        {
            transform.position = Fristpos;
            transform.eulerAngles = new Vector3(0, 0, 0f);


        }
        // If Score > 5  Make Chiken Rotate
        if (CScore.curscore > 5)
        {
            transform.eulerAngles += new Vector3(0, 0, 0.5f) * RotSpeed * Time.deltaTime; 

        }

    }
}
