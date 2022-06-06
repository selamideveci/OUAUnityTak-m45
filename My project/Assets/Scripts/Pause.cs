using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Pause: MonoBehaviour
{
	public GameObject pause;
	
    
   

    void Start(){
	   
	    pause.SetActive(false);
    }


    public void paused(){
	    Time.timeScale = 0;
	    pause.SetActive(true);
    }

    public void unpause()
    {
	    
		    Time.timeScale = 1;
		    pause.SetActive(false);
	    
    }

}