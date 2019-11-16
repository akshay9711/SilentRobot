using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : MonoBehaviour {

    public GameObject Prision;
    public int health = 10;

    //For whiteflash
    private Material matWhite;
    private Material matDefault;
    private UnityEngine.Object explosionRef;
    SpriteRenderer sr;
	
	void Start () {
        //for whiteflash
        sr = GetComponent<SpriteRenderer>();
        matWhite = Resources.Load("WhiteFlash", typeof(Material)) as Material;
        matDefault = sr.material;
        explosionRef = Resources.Load("Explosion");
	}
	
	
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Lazer"))
        {
            health--;
            SoundManager.PlaySound("EnemyDamage");
            sr.material = matWhite;

            if (health <= 0)
            {
                KillSelf();
            }
            else
            {
                Invoke("ResetMaterial", .2f);
            }
        }
    }

    void ResetMaterial()
    {
        sr.material = matDefault;
    }

    private void KillSelf()
    {
        SoundManager.PlaySound("EnemyBlast");
        GameObject explosion = (GameObject)Instantiate(explosionRef);
        explosion.transform.position = new Vector3(transform.position.x, transform.position.y + .3f, transform.position.z);
        Destroy(gameObject);
        Prision.gameObject.SetActive(false);
    }
}
