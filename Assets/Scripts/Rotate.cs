﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

    public float SpeedOfRotate;
	
	void Update ()
    {
        transform.Rotate(0,0,SpeedOfRotate);
	}
}
