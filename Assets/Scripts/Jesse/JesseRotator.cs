﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JesseRotator : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0,35,0) * Time.deltaTime);
    }
}
