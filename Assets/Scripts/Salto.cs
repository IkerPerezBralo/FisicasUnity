using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkSalto();
    }
    void checkSalto()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.up * 4);

        }
    }
}
