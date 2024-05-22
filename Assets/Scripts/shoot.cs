using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shoot : MonoBehaviour
{

    public GameObject bulletPrefab;
    public GameObject bulletSlot;
    // Start is called before the first frame update
    private Quaternion quaternion;
    void Start()
    {
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKeyDown(KeyCode.A)){
            //parentRotation.x -=90.0f;
            quaternion = transform.rotation;
            quaternion.x -= 90;
            Instantiate(bulletPrefab, bulletSlot.transform.position, transform.rotation);
        }
    }
}
