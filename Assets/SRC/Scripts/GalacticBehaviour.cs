﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GalacticBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public float rotatespeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.gameObject.transform.Rotate(0, rotatespeed, 0);
    }
}
