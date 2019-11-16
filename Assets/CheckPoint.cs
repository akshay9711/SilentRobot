using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    private GameMaster gm;
    public GameObject checkpoint, DefaultPosition, DefaultPosition2, DefaultPosition3, DefaultPosition4, DefaultPosition5, PracticeLvlPos;

    //Step 1. When level start this start method called :)
    //- When level start this line will GetComponent from gamemaster script for using in next lines of code :)
    private void Start()
    {
        gm = GameObject.FindGameObjectWithTag("GM").GetComponent<GameMaster>();
    }

    //Step 2. When Player touch checkpoint this method called 
    //- If player touch this gameobject than gm lastchekpointpos value will set this gameobject position value ok
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            gm.lastChekPointPos = transform.position;

            checkpoint.gameObject.SetActive(false);
            SoundManager.PlaySound("CheckPoint");
        }
    }
   public void DefaultPosLevel1()
    {
        gm.lastChekPointPos = DefaultPosition.transform.position;
    }
    public void DefaultPosLevel2()
    {
        gm.lastChekPointPos = DefaultPosition2.transform.position;
    }
    public void DefaultPosLevel3()
    {
        gm.lastChekPointPos = DefaultPosition3.transform.position;
    }
    public void DefaultPosLevel4()
    {
        gm.lastChekPointPos = DefaultPosition4.transform.position;
    }
    public void DefaultPosLevel5()
    {
        gm.lastChekPointPos = DefaultPosition5.transform.position;
    }
    public void PracticeLvlPose()
    {
        gm.lastChekPointPos = PracticeLvlPos.transform.position;
    }
}
