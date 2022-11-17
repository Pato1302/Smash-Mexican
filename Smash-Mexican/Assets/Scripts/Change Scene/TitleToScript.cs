using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleToScript : MonoBehaviour
{
    public void Scene1()
    {
        SceneManager.LoadScene("Main_Menu");
    }
    public void exitgame()
    {
        Debug.Log("exitgame");
        Application.Quit();
    }

}
