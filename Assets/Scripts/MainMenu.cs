using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Thsi Scripts Mange The Scene 
    // Start is called before the first frame update
    // fun of bottom of play
    public void PlayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }
    // fun of bottom of Quit

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();


    }
    public void Menu()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

    }
}
