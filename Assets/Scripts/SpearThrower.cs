using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpearThrower : MonoBehaviour
{
    float chargelevel;
    Spear yyeee;
    public GameObject spear;
    public GameObject position;
    public Quaternion qua;
    private bool isOKToCharge = true;
    
    // Start is called before the first frame update
    void Start()
    {
        yyeee = spear.GetComponent<Spear>();
        chargelevel = 0f;
        StartCoroutine("Charger");
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyUp(KeyCode.Mouse0))
        {

            //Instantiate(spear, position.transform.position, transform.rotation);
            
            qua = Quaternion.FromToRotation(spear.transform.forward, position.transform.forward);
            var newS = Instantiate(spear, position.transform.position, qua);
            newS.transform.rotation = this.gameObject.transform.rotation;
            yyeee.chargelvl = 0;

        }

        if (Input.GetMouseButton(0))
        {
            if (isOKToCharge)
            {
           
            Debug.Log("working?");
                yyeee.chargelvl += 1;
                Debug.Log(yyeee.chargelvl);
                StartCoroutine("Charger");
                isOKToCharge = false;
            }

        }
    }
    IEnumerator Charger()
    {

        
               
        yield return new WaitForSeconds(1);
        isOKToCharge = true;


    }
}
