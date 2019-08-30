using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallRun : MonoBehaviour
{

    public float maxRayDistance;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        WallDetection();



    }

    void WallDetection()
    {


        Debug.DrawRay(transform.position + new Vector3(0, 2, 0), -transform.right, Color.green, 3f);
        Debug.DrawRay(transform.position + new Vector3(0, 2, 0), transform.right, Color.red, 3f);

        RaycastHit raycast;

        if (Physics.Raycast(transform.position + new Vector3(0, 2, 0), -transform.right, out raycast, 3f))
        {
            Debug.Log("left" + raycast.collider.name);
        }
        if (Physics.Raycast(transform.position + new Vector3(0, 2, 0), transform.right, out raycast, 3f))
        {
            Debug.Log("right" + raycast.collider.name);
            
            if (raycast.normal.y ==0)
            {
                Debug.Log("perpendicular");
            }
        }

       

    }
    private void FixedUpdate()
    {
       

    }

}
