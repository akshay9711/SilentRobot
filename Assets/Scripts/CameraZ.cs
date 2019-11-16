using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraZ : MonoBehaviour
{
    private void Start()
    {
        Camera.main.orthographicSize = 10f;
    }
}
