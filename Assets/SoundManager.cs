using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {

   public static AudioClip LaserSound, BlastSound, Jump, CheckPoint, EnemyDamage, PlayerDamageSound, GameOverSound, HealthUpSound, LevelWinSound;
    static AudioSource audioSrc;
	
	void Start ()
    {
        LaserSound = Resources.Load<AudioClip>("LaserShoot");
        BlastSound = Resources.Load<AudioClip>("EnemyBlast");
        Jump = Resources.Load<AudioClip>("Jump");
        CheckPoint = Resources.Load<AudioClip>("CheckPoint");
        EnemyDamage = Resources.Load<AudioClip>("EnemyDamage");
        PlayerDamageSound = Resources.Load<AudioClip>("PlayerDamage");
        GameOverSound = Resources.Load<AudioClip>("GameOver");
        HealthUpSound = Resources.Load<AudioClip>("HealthUp");
        LevelWinSound = Resources.Load<AudioClip>("LevelWin");

        audioSrc = GetComponent<AudioSource>();
	}
	
    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "LaserShoot":
                //thats the reases why sound play only one time becaouse we type playoneshot ok.
                audioSrc.PlayOneShot(LaserSound);
                break;
            case "EnemyBlast":
                audioSrc.PlayOneShot(BlastSound);
                break;
            case "Jump":
                audioSrc.PlayOneShot(Jump);
                break;
            case "CheckPoint":
                audioSrc.PlayOneShot(CheckPoint);
                break;
            case "EnemyDamage":
                audioSrc.PlayOneShot(EnemyDamage);
                break;
            case "PlayerDamage":
                audioSrc.PlayOneShot(PlayerDamageSound);
                break;
            case "GameOver":
                audioSrc.PlayOneShot(GameOverSound);
                break;
            case "HealthUp":
                audioSrc.PlayOneShot(HealthUpSound);
                break;
            case "LevelWin":
                audioSrc.PlayOneShot(LevelWinSound);
                break;
        }
    }
}
