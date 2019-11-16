using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateTankGun : MonoBehaviour {

    private void Start()
    {
       
    }

    void Update()
    {
        /*rotate();

        if (transform.rotation.z <= 18)
        {
            Debug.Log("I M working");
            transform.Rotate(0, 0, -1);
        }

        if(transform.rotation.z >= -8)
        {
            transform.Rotate(0, 0, 1);
        }*/
    }

    void rotate()
    {
        transform.Rotate(0, 0, 1);
    }
}
