using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailScript : MonoBehaviour
{
    public Scene scene;
    [SerializeField] private GameObject OyunBitiþ;
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.CompareTag("Player")) { 
            OyunBitiþ.SetActive(true);
        Time.timeScale = 0;
        }
    }      
}
