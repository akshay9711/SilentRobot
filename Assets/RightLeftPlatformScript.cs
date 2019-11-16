using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeftPlatformScript : MonoBehaviour
{
    public float moveSpeed;
    bool MoveRight = true;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "RightTile")
        {
            MoveRight = false;
        }
        if (collision.gameObject.tag == "LeftTile")
        {
            MoveRight = true;
        }
    }

    void Update()
    {
        if (MoveRight)
            transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
        else
            transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
    }
}
