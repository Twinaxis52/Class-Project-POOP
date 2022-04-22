using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    
    public AudioSource AudioBall;
    public AudioSource AudioPortal;
    public AudioSource AudioSpring;
    public AudioSource AudioSlider;
    public AudioSource AudioJumpPad;
    public AudioSource AudioWcrack;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnCollisionEnter2D(Collision2D collision){
        if(collision.gameObject.tag == "CollisionTag"){
            AudioBall.Play();
        }

         if(collision.gameObject.tag == "SpringSound"){
            AudioSpring.Play();
        }
        if(collision.gameObject.tag == "Slider"){
            AudioSlider.Play();
        }
         if(collision.gameObject.tag == "JumpPad"){
            AudioJumpPad.Play();
        }
        if(collision.gameObject.tag == "Wcrack"){
            AudioWcrack.Play();
        }
       
       
    }

    private void OnTriggerEnter2D(Collider2D col)
	{
		if((col.gameObject.tag == "blue portal")|| (col.gameObject.tag == "orange portal")){
            AudioPortal.Play();
        }

        
	}

    

}
