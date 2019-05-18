using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public float chargelvl;
    Rigidbody rb;
    public GameObject spearboi;
    private SpearThrower spearboiscript;
    // Start is called before the first frame update
    void Start()
    {
        spearboiscript = spearboi.GetComponent<SpearThrower>();
        rb = gameObject.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * (500f * chargelvl));

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
