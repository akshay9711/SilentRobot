using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthControll : MonoBehaviour {

    public GameObject heart1, heart2, heart3, heart4, gameover, Keys, BackKey;
    
    public static int health;

    void Start()
    {
        health = 4;
        heart1.gameObject.SetActive(true);
        heart2.gameObject.SetActive(true);
        heart3.gameObject.SetActive(true);
        heart4.gameObject.SetActive(true);
      gameover.gameObject.SetActive(false);
        Time.timeScale = 1;
    }

    void Update()
    {
        if (health > 4)
            health = 4;
    
        switch (health)
        {
            case 4:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(true);
                break;
            case 3:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(true);
                heart4.gameObject.SetActive(false);
                break;
            case 2:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(true);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                break;
            case 1:
                heart1.gameObject.SetActive(true);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
                break;
            case 0:
                heart1.gameObject.SetActive(false);
                heart2.gameObject.SetActive(false);
                heart3.gameObject.SetActive(false);
                heart4.gameObject.SetActive(false);
              gameover.gameObject.SetActive(true);
                  Keys.gameObject.SetActive(false);
               BackKey.gameObject.SetActive(false);
                Time.timeScale = 0;

                break;
                
        }

    }
    public void JumpSound()
    {
        SoundManager.PlaySound("Jump");
    }

}
