using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LevelDistance : MonoBehaviour
{

    public int Idistance = 1;

    [SerializeField] private TextMeshProUGUI distance;
    [SerializeField] private TextMeshProUGUI gameOverDistance;
   

    private void Start()
    {
        InvokeRepeating("calculateDistance", 0.0f, 0.4f);
        distance.text = "0";
    }

    private void FixedUpdate()
    {
        gameOverDistance.text = "Gidilen Mesafe: " + Idistance.ToString();
    }

    public void calculateDistance()
    {
        Idistance++;
        distance.text = Idistance.ToString();

        
    }
}
