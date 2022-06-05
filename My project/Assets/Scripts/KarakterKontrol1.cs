using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterKontrol1 : MonoBehaviour
{
    public float moveSpeed = 6;
    public float leftRightSpeed = 4;
    public GameManager gameManager;

    

    

    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed, Space.World);
        
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            if (this.gameObject.transform.position.x >LevelBoundary.leftSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed);
            }
            
        }

        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            if (this.gameObject.transform.position.x < LevelBoundary.rightSide)
            {
                transform.Translate(Vector3.left * Time.deltaTime * leftRightSpeed * -1);
            }
        }
    }

    private IEnumerator WaitAndRestart(float waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        gameManager.gameOver();

    }
}
