using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PortalGunner : MonoBehaviour
{
    //portal prefabs
    public GameObject Portal1;

    public GameObject Portal2;

    public GameObject particle;

    public GameObject startpoint;

    public float range;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("1"))
        {
            Debug.Log("firing");

            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.collider != null)
                {
                    Portal1.transform.position = hit.point;
                    Portal1.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);
                   
                    if (Portal1.transform.rotation.y <= -80)
                    {

                    Vector3 temp = new Vector3(0, 10f, 0);
                    Portal1.transform.position += temp;
                    }
                     else
                     {
                    Debug.Log("Working");
                    Portal1.transform.position = hit.point + (transform.forward * 1.0f);
                     }

                    Portal1.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);
                    Instantiate(particle,
                                     startpoint.transform.position,
                                     startpoint.transform.rotation);
                }
            }
        }
        if (Input.GetKeyDown("2"))
        {
            
            Debug.Log("firing");
            Ray ray;
            RaycastHit hit;
            ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                if (hit.collider != null)
                  
                Portal2.transform.position = hit.point;
                Portal2.transform.rotation = Quaternion.FromToRotation(Vector3.forward, hit.normal);


            }
        }
    }
}
