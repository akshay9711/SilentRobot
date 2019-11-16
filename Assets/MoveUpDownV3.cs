using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDownV3 : MonoBehaviour
{
    public float moveSpeed;
    bool MoveUp = true;
    public Collider2D ColliderTF;

    private void Start()
    {
        ColliderTF = GetComponent<Collider2D>();
    }

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
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player")
        {
            //ColliderTF.enabled = false;
            moveSpeed = 20;
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
