using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveUpDown : MonoBehaviour {

    public float moveSpeed;
    public float UpMove,DownMove;

    bool MoveUp = true;

    void Update()
    {
        //If y value more than y than MoveRight will false
        if (transform.position.y > UpMove)
            MoveUp = false;
        if (transform.position.y < DownMove)
            MoveUp = true;

        if (MoveUp)
            transform.position = new Vector2(transform.position.x, transform.position.y + moveSpeed * Time.deltaTime);
        else
            transform.position = new Vector2(transform.position.x, transform.position.y - moveSpeed * Time.deltaTime);
    }
}
