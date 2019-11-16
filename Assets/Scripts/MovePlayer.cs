using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour {

    public GameObject GameOver, HealthUp, FinishPlatform, FinishPlatStart, LevelText, Controllers;

    public float PlayerMoveSpeed;
    public bool isGrounded = false;
    public float jumpforce;

    private Rigidbody2D rb;

    bool Booljump;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Controllers.gameObject.SetActive(true);
    }

    void FixedUpdate()
    {
        if (HealthControll.health == 0)
        {
            Debug.Log("i m working sound play done");
            SoundManager.PlaySound("GameOver");
        }
        PlayerFace();
        Jump();
        //For Movement of player
        Vector3 Movement = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += Movement * Time.deltaTime * PlayerMoveSpeed;
    }

    void Jump()
    {
        if (Booljump || Input.GetKeyDown(KeyCode.UpArrow) && isGrounded == true)
        {
            GETJUMP();
        }
    }

   public void JumpTouchTrigger(bool canmove)
    {
        Booljump = canmove;
    }

    void GETJUMP()
    {
        gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, jumpforce), ForceMode2D.Impulse);
    }

    //Vector3 playerscale is just a name of vector3 and jisse ye script jiss object ke saath attach he ussi pe effect hoga ok.
    void PlayerFace()
    {
        Vector3 PlayerScale = transform.localScale;
        if(Input.GetAxis("Horizontal") < 0)
        {
            PlayerScale.x = -9.50371f;
        }

        if(Input.GetAxis("Horizontal") > 0)
        {
            PlayerScale.x = 9.50371f;
        }
        transform.localScale = PlayerScale;
    }

    //For damage check
    public void OnCollisionEnter2D(Collision2D collision)
    {
        

        if (collision.collider.tag == "Obstacle")
        {
            SoundManager.PlaySound("PlayerDamage");
            HealthControll.health -= 1;
            
        }
        if (collision.collider.tag == "PowerfullObsracle")
        {
            GameOver.gameObject.SetActive(true);
            SoundManager.PlaySound("GameOver");
            Time.timeScale = 0;
        }
        if(collision.collider.tag == "FinishPlatStart")
        {
            FinishPlatform.gameObject.SetActive(true);
            FinishPlatStart.gameObject.SetActive(false);
        }
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "EnemyBullet")
        {
            SoundManager.PlaySound("PlayerDamage");
            HealthControll.health -= 1;
        }
        if(collision.gameObject.tag == "HealthUp")
        {
            HealthControll.health = 4;
            HealthUp.gameObject.SetActive(false);
            SoundManager.PlaySound("HealthUp");
        }
        if(collision.gameObject.tag == "LevelText")
        {
            LevelText.gameObject.SetActive(false);
        }
    }
}
