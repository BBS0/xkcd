using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Mover : MonoBehaviour {

    
    public Animator animator;

	// Use this for initialization
	void Start () {
        


    }
	
	// Update is called once per frame
	void Update () {

      

        if (Input.GetAxis("Vertical") > 0)
        {
            animator.SetFloat("WalkSpeed", 0.3f);
        }
        else if (Input.GetKey(KeyCode.LeftShift) && Input.GetAxis("Vertical") > 0)
        {
            animator.SetFloat("WalkSpeed", 0.5f);

        }
        else
        {

            //Stop running
            animator.SetFloat("WalkSpeed", 0.0f);
        }

       

    }

}
