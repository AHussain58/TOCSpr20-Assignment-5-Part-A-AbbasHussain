﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlaceString : MonoBehaviour

{
    
    public Text nameLable;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    


    // Update is called once per frame
    void Update()
    {
        Vector3 namePose = Camera.main.WorldToScreenPoint(this.transform.position);
        nameLable.transform.position = namePose;
    }
}
