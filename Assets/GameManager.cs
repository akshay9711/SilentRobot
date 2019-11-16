using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public GameObject LevelFailed, Button, ButtonPressed, Jail, Help, MainDoorButton, MainDoor;
    public GameObject backround, LavaBackround, BlackBackround, GreenBackround, PurpleBackround, GrayBackround, DiamondBackround;

    public void quit()
    {
        Application.Quit();
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
        Time.timeScale = 1;
        MusicOn();
    }

    public void ExitToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        MusicOn();
    }

    public void LoadCurrentScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }

    //This all collision is for button and others related. OK
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Button")
        {
            Button.gameObject.SetActive(false);
            ButtonPressed.gameObject.SetActive(true);
            Jail.gameObject.SetActive(false);
        }

        if (collision.collider.tag == "MainDoorButton")
        {
            MainDoorButton.SetActive(false);
            MainDoor.SetActive(false);
        }

        if(collision.collider.tag == "Finish")
        {
            SoundManager.PlaySound("LevelWin");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Help")
        {
            Help.gameObject.SetActive(true);
        }

        if (collision.gameObject.name == "HelpEND")
        {
            Help.gameObject.SetActive(false);
        }

        if (collision.gameObject.tag == "LavaEnter")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(true);
            BlackBackround.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "LavaExit")
        {
            backround.gameObject.SetActive(true);
            LavaBackround.gameObject.SetActive(false);
        }
        if (collision.gameObject.tag == "BlackblackEnter")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(true);
        }
        if (collision.gameObject.tag == "BlackbackExit")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(true);
            BlackBackround.gameObject.SetActive(false);
        }
        if(collision.gameObject.name == "PurpleEnter")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(false);
            GreenBackround.gameObject.SetActive(false);

            PurpleBackround.gameObject.SetActive(true);
        }
        if (collision.gameObject.name == "PurpleExit")
        {
            backround.gameObject.SetActive(true);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(false);
            GreenBackround.gameObject.SetActive(false);

            PurpleBackround.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "GrayEnter")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(true);
            GreenBackround.gameObject.SetActive(false);
            PurpleBackround.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "GreenEnter")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(false);
            GreenBackround.gameObject.SetActive(true);
            PurpleBackround.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "DiamondEnter")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(false);
            GreenBackround.gameObject.SetActive(false);
            PurpleBackround.gameObject.SetActive(false);
            DiamondBackround.gameObject.SetActive(true);
        }
        if (collision.gameObject.name == "DiamondExit")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(true);
            GrayBackround.gameObject.SetActive(false);
            GreenBackround.gameObject.SetActive(false);
            PurpleBackround.gameObject.SetActive(false);
            DiamondBackround.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "BlackExit")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(true);
            GreenBackround.gameObject.SetActive(false);
            PurpleBackround.gameObject.SetActive(false);
            DiamondBackround.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "BlueEnter")
        {
            backround.gameObject.SetActive(true);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(false);
            GreenBackround.gameObject.SetActive(false);
            PurpleBackround.gameObject.SetActive(false);
            DiamondBackround.gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "BlueExit")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(false);
            GreenBackround.gameObject.SetActive(false);
            PurpleBackround.gameObject.SetActive(false);
            DiamondBackround.gameObject.SetActive(true);
        }
        if (collision.gameObject.name == "GreenEnter")
        {
            backround.gameObject.SetActive(false);
            LavaBackround.gameObject.SetActive(false);
            BlackBackround.gameObject.SetActive(false);
            GrayBackround.gameObject.SetActive(false);
            GreenBackround.gameObject.SetActive(true);
            PurpleBackround.gameObject.SetActive(false);
            DiamondBackround.gameObject.SetActive(false);
        }
        

    }

    public void LevelTwo()
    {
        SceneManager.LoadScene("Level2");
        MusicOn();
    }
    public void LevelThree()
    {
        SceneManager.LoadScene("Level3");
        MusicOn();
    }
    public void LevelFour()
    {
        SceneManager.LoadScene("Level4");
        MusicOn();
    }
    public void LevelFive()
    {
        SceneManager.LoadScene("Level5");
        MusicOn();
    }
    public void LevelSix()
    {
        SceneManager.LoadScene("Level6");
        MusicOn();
    }
    public void LevelSeven()
    {
        SceneManager.LoadScene("Level7");
        MusicOn();
    }
    public void LevelEight()
    {
        SceneManager.LoadScene("Level8");
        MusicOn();
    }
    public void LevelNine()
    {
        SceneManager.LoadScene("Level9");
        MusicOn();
    }
    public void LevelTen()
    {
        SceneManager.LoadScene("Level10");
        MusicOn();
    }
    public void EndGame()
    {
        SceneManager.LoadScene("End");
        Resume();
    }
    public void CreditScene()
    {
        SceneManager.LoadScene("Credits");
        Resume();
    }
    public void PracticeLvl()
    {
        SceneManager.LoadScene("PracticeLevel");
        MusicOn();
        Resume();
    }


    public void MusicOff()
    {
        AudioListener.volume = 0.0f;
    }
    public void MusicOn()
    {
        AudioListener.volume = 1.0f;
    }
}
