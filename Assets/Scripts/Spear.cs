using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spear : MonoBehaviour
{
    public float chargelvl;
    Rigidbody rb;
    public GameObject spearboi;
    private SpearThrower spearboiscript;
    public Quaternion qua;
    // Start is called before the first frame update
    void Start()
    {
      
       


      
    }

    private void Awake()
    {
        Debug.Log("AWAKEN");

        rb = gameObject.GetComponent<Rigidbody>();

        //rb.AddForce(gameObject.transform.forward = Vector3.Slerp(gameObject.transform.forward, transform.forward, Time.deltaTime * 5) * 18000);
        //gameObject.transform.parent = null;


        rb.AddForce (transform.forward * (10f * chargelvl), ForceMode.Impulse);

        StartCoroutine(suicide());
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
