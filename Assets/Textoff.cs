using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textoff : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Destroy", 5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Destroy()
    {
        gameObject.SetActive(false);
    }
}
