using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FailScript : MonoBehaviour
{
    public Scene scene;
    void Start()
    {
        scene = SceneManager.GetActiveScene();
    }

    // Update is called once per frame
    private void OnTriggerEnter(Collider obstacle)
    {
        if (obstacle.CompareTag("Engel"))
          SceneManager.LoadScene(scene.buildIndex + 1);
    }
}
