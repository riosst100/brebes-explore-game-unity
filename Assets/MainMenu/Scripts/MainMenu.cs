using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MulaiGame() 
    {
        SceneManager.LoadScene("Playground");
    }

    public void Keluar() 
    {
        Application.Quit();
    }
}
