using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class movetheball : MonoBehaviour
{
    // Start is called before the first frame update

    public float movespeed = 5;
    private float horizontalinput;
    private float forwardinput;

    public float Turnspeed;
    public float upPower;
    Rigidbody rigid;
    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rigid.AddForce(Vector3.forward*movespeed);
        horizontalinput = Input.GetAxis("Horizontal");
        forwardinput = Input.GetAxis("Vertical");
        if(transform.position.y < 1) transform.position = new Vector3(transform.position.x, 1, transform.position.z);
        if(Input.GetKey(KeyCode.Space)){
            //transform.Translate(Vector3.up * upPower * Time.deltaTime);
            transform.Rotate(Vector3.left * Turnspeed * Time.deltaTime);
            Debug.Log("keydonwSpace");
        }
        else if(transform.rotation.x < 0) transform.Rotate(Vector3.right * Turnspeed * Time.deltaTime);

        if(Input.GetKey(KeyCode.A)){
            transform.position = new Vector3(1,1,1);
            transform.rotation = Quaternion.Euler(0,0,0);
        }
        transform.Translate(Vector3.forward * movespeed * forwardinput * Time.deltaTime);
        transform.Rotate(Vector3.up, Turnspeed * horizontalinput * Time.deltaTime);
        //transform.Translate(Vector3.forward * Time.deltaTime * movespeed * forwardinput);
        //transform.Translate(Vector3.right * Time.deltaTime * movespeed * horizontalinput);
    }
}
