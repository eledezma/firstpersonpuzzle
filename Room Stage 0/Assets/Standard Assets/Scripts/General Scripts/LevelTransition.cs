﻿using UnityEngine;
using System.Collections;

public class LevelTransition : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {


            Application.LoadLevel(Application.loadedLevel + 1);
        }
    }
}
