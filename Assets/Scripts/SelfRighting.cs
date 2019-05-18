using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfRighting : MonoBehaviour
{
    public Rigidbody rb;
    float rightendampening = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
       

        // Remember to use FixedUpdate when applying continuous forces or torques!

       
        {
            var forwardxz = rb.transform.forward;
            forwardxz.y = 0;
            rb.transform.forward = Vector3.Lerp(rb.transform.forward, forwardxz, rightendampening * Time.deltaTime);
        }
    }
}
