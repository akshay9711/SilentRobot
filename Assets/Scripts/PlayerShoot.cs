using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
    public GameObject Lazer;
    public float LazerSpeed;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void ShootLazer()
    {
        GameObject Getlazer = Instantiate(Lazer, transform.position, Quaternion.identity) as GameObject;
        Rigidbody2D getlazerRb = Getlazer.GetComponent<Rigidbody2D>();
        getlazerRb.AddForce(Vector2.right * LazerSpeed);
        
        //Dont forgot while destroying lazer you need destroy instantiate lazer not main reason.
        Destroy(Getlazer, 2f);
    }
    
}
