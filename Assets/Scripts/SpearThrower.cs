using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearThrower : MonoBehaviour
{
    float chargelevel;
    Spear yyeee;
    public GameObject spear;
    public GameObject head;
    // Start is called before the first frame update
    void Start()
    {
        yyeee = spear.GetComponent<Spear>();
        chargelevel = 0f;
    }

    // Update is called once per frame
    void Update()
    {
       if (Input.GetMouseButton(0))
        {
            yyeee.chargelvl += 0.4f;
        }
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
         
            Instantiate(spear, head.transform.position, gameObject.transform.rotation );
            yyeee.chargelvl = 0;

        }

    }
}
