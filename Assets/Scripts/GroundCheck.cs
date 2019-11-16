using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour {

    public GameObject Player;
    
	
	void Start ()
    {
        Player = gameObject.transform.parent.gameObject;
	}
	
	void Update ()
    {
		
	}

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<MovePlayer>().isGrounded = true;
        }
    }

    public void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.tag == "Ground")
        {
            Player.GetComponent<MovePlayer>().isGrounded = false;
        }
    }
}
