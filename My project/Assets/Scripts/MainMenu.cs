using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MainMenu : MonoBehaviour
{


    public void PlayGame()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        
    }
    public void QuitGame()
    {
        Debug.Log("Oyunda Çıkıldı");
        Application.Quit();
    }

   public void Yeniden() 
    {

        SceneManager.LoadScene("Oyun");
        
    }
   public void Giriş() 
   {

       SceneManager.LoadScene("Giriş");
        
   }
    
}