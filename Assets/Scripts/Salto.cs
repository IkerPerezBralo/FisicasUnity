using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salto : MonoBehaviour
{
    [SerializeField]
    public int jumpForce = 200;

    [SerializeField]
    public bool jumpAble = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        checkJump();
        checkMovement();
    }

    void checkJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && jumpAble)
        {
            this.GetComponent<Rigidbody>().AddForce(Vector3.up * jumpForce);
        }

    }

    void checkMovement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            // this.GetComponent<Rigidbody>().AddForce(Vector3.forward * jumpForce);
            transform.Translate(new Vector3(0,0,5) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            // this.GetComponent<Rigidbody>().AddForce(Vector3.back * jumpForce);
            transform.Translate(new Vector3(0, 0, -5) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // this.GetComponent<Rigidbody>().AddForce(Vector3.left * jumpForce);
            transform.Translate(new Vector3(-5, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            // this.GetComponent<Rigidbody>().AddForce(Vector3.right * jumpForce);
            transform.Translate(new Vector3(5, 0, 0) * Time.deltaTime);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            Destroy(gameObject);
        }

        jumpAble = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        jumpAble = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer == LayerMask.NameToLayer("ground"))
        {
            Destroy(gameObject);
        }
    }
}
