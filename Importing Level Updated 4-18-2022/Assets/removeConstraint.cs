using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class removeConstraint : MonoBehaviour
{
    public Rigidbody2D rb;
    public bool Active = false;

    /*public void drop()
    {
        Active = false;
    }
    
    public void OnClick(){
        if (Active)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
    }

    void OnMouseDrag(){
        if (Active)
            rb.constraints = RigidbodyConstraints2D.None;
    }*/

    /*private void Awake() 
    {
        if (Active)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
    }*/

   void OnEnable()
   {
       if (Active == true)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
   }


   void Start()
   {
       if (Active == true)
        {
            rb.constraints = RigidbodyConstraints2D.None;
        }
   }
}
