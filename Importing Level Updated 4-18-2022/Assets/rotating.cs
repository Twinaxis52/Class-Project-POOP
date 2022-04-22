using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotating : MonoBehaviour
{
    private float rot2;
    public float RotationSpeed;
    public bool ClockwiseRotation;
    public bool Active = false;
    public bool first = true;
    public AudioSource AudioWoodGear;

    // Update is called once per frame
    void Update()
    {
        if(Active == true)
        {
             if(first==true)
             {
                 AudioWoodGear.Play();
                 first = false;
             }
            if(ClockwiseRotation == false)
            {
                rot2 += Time.deltaTime * RotationSpeed;
            }
            else{
                rot2 += Time.deltaTime * RotationSpeed;
            }
        transform.rotation = Quaternion.Euler(0, 0, rot2);
        }
    }
}
