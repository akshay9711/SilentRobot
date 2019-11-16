using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UiControl : MonoBehaviour
{
    public Button level2, level3, level4, level5, level6, level7, level8, level9, level10;
    public GameObject menu, ExitWarning;

    private void Start()
    {
        menu.gameObject.SetActive(true);
        ExitWarning.gameObject.SetActive(false);
    }

    void Update()
    {
        LevelUnlock();
    }

    public void LevelUnlock()
    {
        if (PlayerPrefs.GetInt("Level1") == 1)
        {
            level2.interactable = true;
        }
        if (PlayerPrefs.GetInt("Level2") == 2)
        {
            level3.interactable = true;
        }
        if (PlayerPrefs.GetInt("Level3") == 3)
        {
            level4.interactable = true;
        }
        if (PlayerPrefs.GetInt("Level4") == 4)
        {
            level5.interactable = true;
        }
        if (PlayerPrefs.GetInt("Level5") == 5)
        {
            level6.interactable = true;
        }
        if (PlayerPrefs.GetInt("Level6") == 6)
        {
            level7.interactable = true;
        }
        if (PlayerPrefs.GetInt("Level7") == 7)
        {
            level8.interactable = true;
        }
        if (PlayerPrefs.GetInt("Level8") == 8)
        {
            level9.interactable = true;
        }
        if (PlayerPrefs.GetInt("Level9") == 9)
        {
            level10.interactable = true;
        }
    }

    public void ResetPlayerPrefs()
    {
        //For reset game data 
        level2.interactable = false;
        level3.interactable = false;
        level4.interactable = false;
        level5.interactable = false;
        level6.interactable = false;
        level7.interactable = false;
        level8.interactable = false;
        level9.interactable = false;
        level10.interactable = false;
        PlayerPrefs.DeleteAll();
    }
}
