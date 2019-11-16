using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeftRight : MonoBehaviour {

   public float moveSpeed;
   public float RightMove, LeftMove;

   bool MoveRight = true;
	
	void Update ()
    {
        //If x value more than x than MoveRight will false
        if (transform.position.x > RightMove)
            MoveRight = false;
        if (transform.position.x < LeftMove)
            MoveRight = true;

        if (MoveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
	}
}
