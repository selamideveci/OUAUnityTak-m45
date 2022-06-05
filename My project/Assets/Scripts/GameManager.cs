using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject OyunBitiş;
    public static bool gameOver;
   
    void Start()
    {
        gameOver = false;
    }

    // Update is called once per frame
    public void Update()
    {
        if (gameOver)
        {
            Time.timeScale = 0;
            OyunBitiş.SetActive(true);
        }

    }
}
