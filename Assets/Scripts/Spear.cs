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
     //   spearboi = 
      //  spearboiscript = spearboi.GetComponent<SpearThrower>();
      //  rb = gameObject.GetComponent<Rigidbody>();
    //    rb.AddForce(transform.forward * (500f * chargelvl));
        //StartCoroutine(suicide());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator suicide ()
    {
        yield return new WaitForSeconds(5);
        Destroy(gameObject);
    }
}
