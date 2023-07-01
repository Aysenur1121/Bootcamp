using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public void SingleButton()
    {
        SceneManager.LoadScene(1); // 1. sahne single player 1. bölümü temsil ediyor
    }

    public void MultiplayerButton()
    {
        //SceneManager.LoadScene(5); // burada 5. sahne oyunu başlattığımız ekranı temsil ediyor(oyuncu beklediğimiz..)
    }
    public void QuitButton()
    {
        Debug.Log("QUIT!!");
        Application.Quit(); //build edildiğinde çalışır, oyunu kapatacak
    }
    
}
