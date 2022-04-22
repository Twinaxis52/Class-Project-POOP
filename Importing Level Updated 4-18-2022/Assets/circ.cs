using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class circ : MonoBehaviour
{
    private float token = 0;
    private void OnTriggerEnter2D(Collider2D other) {
        if(other.transform.tag == "TOKEN"){
            Destroy(other.gameObject);
            ScoreManager.instance.AddPoint();
        }

        if(other.transform.tag == "Goal"){
            ScoreManager.instance.stopPoints();
            TimerCounter.instance.stopTimer();
        }

        if((other.gameObject.tag == "blue portal")|| (other.gameObject.tag == "orange portal")){
            ScoreManager.instance.AddPoint();
        }
    }

    public void OnCollisionEnter2D(Collision2D collision){

         if(collision.gameObject.tag == "SpringSound"){
             ScoreManager.instance.AddPoint();
        }
        if(collision.gameObject.tag == "Slider"){
             ScoreManager.instance.AddPoint();
        }
         if(collision.gameObject.tag == "JumpPad"){
             ScoreManager.instance.AddPoint();
        }
        if(collision.gameObject.tag == "Wcrack"){
             ScoreManager.instance.AddPoint();
        }
       
       
    }
    
}
