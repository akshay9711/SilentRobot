using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiniGunRight : MonoBehaviour
{
    public GameObject Bullet;
    public float BulletSpeed;

    void Start()
    {
        //For call shoot method every second :)
        InvokeRepeating("shoot", 1, 2);
    }


    void Update()
    {

    }

    public void shoot()
    {
        GameObject Getbullet = Instantiate(Bullet, transform.position, Quaternion.identity) as GameObject;
        Rigidbody2D getbulletRb = Getbullet.GetComponent<Rigidbody2D>();
        getbulletRb.AddForce(Vector2.left * BulletSpeed);
        //Dont forgot while destroying bullet you need destroy instantiate bullet not main reason.
        Destroy(Getbullet, 5f);
    }
}
