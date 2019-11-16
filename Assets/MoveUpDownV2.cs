using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDownV2 : MonoBehaviour
{
    public float moveSpeed;
    bool MoveUp = true;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "UpTile")
        {
            MoveUp = false;
        }
        if (collision.gameObject.tag == "DownTile")
        {
            MoveUp = true;
        }
    }

    void Update()
    {
        if (MoveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
    }

    
}
