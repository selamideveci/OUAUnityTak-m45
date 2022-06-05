using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
   public static int point;

   private void Update()
   {
      Debug.Log("The score is " + point);
   }

   private void OnTriggerEnter(Collider other)
   {
      if (other.gameObject.tag== "puan")
      {
         point++;
         Destroy(other.gameObject);
         
      }
   }
}
