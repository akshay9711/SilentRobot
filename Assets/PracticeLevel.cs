using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PracticeLevel : MonoBehaviour
{
    public GameObject YouWin;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Finish")
        {
            YouWin.gameObject.SetActive(true);
        }
    }
}
