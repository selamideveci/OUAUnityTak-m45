using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Falling : MonoBehaviour
{
    public Collider bcol;
    // Start is called before the first frame update
    void Start()
    {

        bcol = GetComponent<BoxCollider>();

    }


   
        void OnTriggerEnter(Collider colliderofcube)
        {
            if (colliderofcube.attachedRigidbody)
                colliderofcube.attachedRigidbody.useGravity = true;
               
        }
 
  
}
