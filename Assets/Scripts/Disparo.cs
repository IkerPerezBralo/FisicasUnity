using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparo : MonoBehaviour
{
    [SerializeField]
    public GameObject ammo;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            GameObject newbullet =  Instantiate(ammo, this.transform.position, this.transform.rotation);
            newbullet.GetComponent<Rigidbody>().AddForce(this.transform.right * 1000);
            Destroy(newbullet, 1f);
        }
    }
}
