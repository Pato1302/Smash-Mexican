using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToMainMenu : MonoBehaviour
{
    public void UnJugador()
    {
        SceneManager.LoadScene("Character_Select");
    }

    public void DosJugadores()
    {
        SceneManager.LoadScene("Character_Select");
    }

    public void Practica()
    {
        SceneManager.LoadScene("Character_Select");
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Titulo");
    }
}
