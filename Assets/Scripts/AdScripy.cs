using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

public class AdScripy : MonoBehaviour
{
    void Start()
    {
        if (!Advertisement.isInitialized)
        {
            Advertisement.Initialize("1861622");
        }
    }

    public void showVideoAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
        }
    }
}
