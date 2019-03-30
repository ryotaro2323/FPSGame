using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Muzzle : MonoBehaviour
{

    public GameObject bullet;

    void Start()
    {

    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shot();
        }
    }

    void Shot() {
        GameObject obj;
        obj = GameObject.Instantiate (bullet);
        obj.transform.position = transform.position;
        obj.GetComponent<Rigidbody> ().AddForce (transform.forward * 1000);
    }
}