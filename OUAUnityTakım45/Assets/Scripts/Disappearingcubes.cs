using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disappearingcubes : MonoBehaviour
{
    public GameObject cube;
    public Collider disappearer;
    // Start is called before the first frame update
    void Start()
    {
        disappearer = GetComponent<BoxCollider>();
        
    }

    private void OnTriggerEnter(Collider colliderofcube)
    {
        colliderofcube.gameObject.SetActive(false);
    }

}
