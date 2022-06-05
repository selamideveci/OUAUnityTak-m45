using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class Score : MonoBehaviour
{
    
    public static int totalscore;
    [SerializeField] private TextMeshProUGUI scoretext;
    [SerializeField] private TextMeshProUGUI gameOverScoretext;
    
    [SerializeField] private GameObject OyunBitiş;

   

   

    private void Update()
    {
        scoretext.text = totalscore.ToString();
        

        scoretext.text = "Toplanan Yem: " + totalscore.ToString();
        gameOverScoretext.text = "Toplanan Yem: " + totalscore.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("puan"))
        {
            Destroy(other.gameObject);
            totalscore++;
            scoretext.text = totalscore.ToString();
        }

        if (other.gameObject.CompareTag("Engel"))
        {
            OyunBitiş.SetActive(true);
            Time.timeScale = 0;
            Destroy(other.gameObject);
        }
    }

   


   
}
