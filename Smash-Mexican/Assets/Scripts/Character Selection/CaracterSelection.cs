using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CaracterSelection : MonoBehaviour
{

    public void DrSimi()
    {
        PlayerPrefs.SetInt("Character", 1);
    }

    public void MamaLucha()
    {
        PlayerPrefs.SetInt("Character", 2);
    }

    public void SusanaDis()
    {
        PlayerPrefs.SetInt("Character", 3);
    }

    public void ChapulinColorado()
    {
        PlayerPrefs.SetInt("Character", 4);
    }

    public void Go()
    {
        //SceneManager.LoadScene("DesertScene_mobile");
        //SceneManager.LoadScene("Cami Nv1", LoadSceneMode.Additive);
        //SceneManager.LoadScene("Rami Nv1", LoadSceneMode.Additive);
    }
}
