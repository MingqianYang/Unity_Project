﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public static MusicManager instance;

    [System.Obsolete]
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
         //   DontDestroyOnLoad(gameObject);
        }
        else
        {
           // DestroyObject(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
