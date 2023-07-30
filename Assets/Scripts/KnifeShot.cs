using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class KnifeShot : MonoBehaviour
{
    // This Bolck To Audio 
    [SerializeField]
    private AudioClip kak;
    [SerializeField]
    private AudioClip Lose;
    [SerializeField]
    private AudioClip KnifeShoot;
    private AudioSource MyAd;
    /// <summary>
    /// /////////////////////////////////////////////////////////////////////////////\\\\\\\\\\\\\\\\\
    /// </summary>
    /// Varible Needed
    // became true when kinfe shoted
    public bool Shot;
    ///  Speed of Kinfe
    public int Speed;
    // Save Frist Pos Of Kinfe
    public Vector3 lastpos;
    // Became True When kinfe Hit Chiken
    public static bool Hit = false;
    // Became True When Lose The Trys
    public static bool lose = false;
    // vector To Save (X,Y) Of Screen
    private Vector2 ScreenBounder;
    public static float XValue=0;
    public static float YValue=0;
    // Start is called before the first frame update
    void Start()
    {
        // Save The X And Y In Vector
        ScreenBounder = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // aduio souse
        MyAd = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update()
    {
        // store X And Y of Screen
        XValue = ScreenBounder.x;
        YValue = ScreenBounder.y;
        // if press in mouse And NumberOfTry > 0
        if (Input.GetMouseButtonDown(0)&& NumOFTy.NumofTrys >= 1)
        {
            Shot = true;

        }
        // in this If Statment Check if Kinfe Hit Chiken
        if (Shot)
        {
            MyAd.clip = KnifeShoot;
            MyAd.Play();
            lastpos = transform.position;
            transform.position += Vector3.up * Speed * Time.deltaTime;
            RaycastHit2D hit = Physics2D.Linecast(lastpos, transform.position);
            // this if knife hit
            if (hit.collider != null)
            {
                Hit = true;
                Shot = false;
                CScore.curscore += 1;
                transform.position = new Vector3(0, -3, -1);
                MyAd.clip = kak;
                MyAd.Play();

            }
            // if Kinfe Get out Of Scene
            if (transform.position.y > YValue)
            {
                transform.position = new Vector3(0, -3, -1);
                NumOFTy.NumofTrys--;
                Shot = false;
                if (NumOFTy.NumofTrys < 1)
                {
                    lose = true;
                    MyAd.clip = Lose;
                    MyAd.Play();
                    Debug.Log("Game Over"); 
                }
            }

        }
        // This To Restart The Game
        if (Input.GetMouseButtonDown(0)&& NumOFTy.NumofTrys < 1)
        {
            NumOFTy.NumofTrys = 3;
            CScore.curscore = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            lose = false;
        }



    }
}
    
   

