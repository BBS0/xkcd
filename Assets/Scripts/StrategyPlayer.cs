using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrategyPlayer : MonoBehaviour
{

    public Terrain mainTerrain;
    public Camera StratCamera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = StratCamera.ScreenPointToRay(Input.mousePosition);
            if (mainTerrain.GetComponent<Collider>().Raycast(ray, out hit, Mathf.Infinity))
            {
                transform.position = hit.point;
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                Vector3 scale = new Vector3(15, 15, 45);
                cube.transform.localScale = scale;
                cube.transform.position = hit.point;
            }
        }

        var d = Input.GetAxis("Mouse ScrollWheel");
        if (d > 0f)
        {
            // scroll up
            StratCamera.fieldOfView++;
        }
        else if (d < 0f)
        {
            // scroll down
            StratCamera.fieldOfView--;
        }

    }
}
