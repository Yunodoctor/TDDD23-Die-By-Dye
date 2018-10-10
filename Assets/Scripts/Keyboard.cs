﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keyboard : MonoBehaviour
{
    //Sprites
    public Image Keyboards;
    public Sprite KeyboardOneDown;
    public Sprite KeyboardTwoDown;
    public Sprite KeyboardThreeDown;
    public Sprite KeyboardFourDown;
    public Sprite KeyboardAllUp;

    //private Weapon weapon;

    void Start()
    {
        //weapon = GetComponent<Weapon>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Keyboards.sprite = KeyboardOneDown;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Keyboards.sprite = KeyboardTwoDown;
        }

        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Keyboards.sprite = KeyboardThreeDown;
        }

        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            Keyboards.sprite = KeyboardFourDown;
        }
    }

}


