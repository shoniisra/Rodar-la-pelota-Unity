﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointTurnController : MonoBehaviour
{
    Vector3 rotacion = new Vector3(15,30,45);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(rotacion*Time.deltaTime);
    }

}
