using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class MoveCherecter : MonoBehaviour {

    private Rigidbody2D rb;
    public float movespeed;
    public float jumpforce;
    private float dirX;
    private bool facingRight = true;
    private Vector3 localScale;

    //Var for PlayerShooting
    public GameObject Lazer;
    public float LazerDir;
    public float LazerSpeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        localScale = transform.localScale;
    }


    void Update()
    {
        dirX = CrossPlatformInputManager.GetAxis("Horizontal") * movespeed;

        if (CrossPlatformInputManager.GetButtonDown("Jump") && rb.velocity.y == 0)
            rb.AddForce(Vector2.up * jumpforce);
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(dirX, rb.velocity.y);
    }

    private void LateUpdate()
    {
        if (dirX > 0)
        {
            facingRight = true;
            LazerDir = 1;
        }
           
        else if (dirX < 0)
        {
            facingRight = false;
            LazerDir = -1;
        }

        if (((facingRight) && (localScale.x < 0)) || ((!facingRight) && (localScale.x > 0)))
            localScale.x *= -1;

        transform.localScale = localScale;
    }

    //PlayerShoot 
    public void ShootLazer()
    {
        GameObject Getlazer = Instantiate(Lazer, transform.position, Quaternion.identity) as GameObject;
        Rigidbody2D getlazerRb = Getlazer.GetComponent<Rigidbody2D>();
        getlazerRb.AddForce(new Vector2(LazerDir, 0) * LazerSpeed);
        SoundManager.PlaySound("LaserShoot");
        //Dont forgot while destroying lazer you need destroy instantiate lazer not main reason.
        Destroy(Getlazer, 0.4f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == ("speedup"))
        {
            movespeed = 20;
        }
        if (collision.gameObject.name == ("speednormal"))
        {
            movespeed = 8;
        }
    }
}
