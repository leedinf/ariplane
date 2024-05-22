using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletMove : MonoBehaviour
{
    public float bulletSpeed = 200;
    public float bound = 100;
    private Vector3 shootPosition;
    // Start is called before the first frame update
    void Start()
    {
        shootPosition = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Vector3.Distance(transform.position, shootPosition) > bound){
            Destroy(gameObject);
        }
        transform.Translate(Vector3.forward * bulletSpeed * Time.deltaTime);
    }
}
