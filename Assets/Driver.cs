using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerspeed = 20f;
    [SerializeField] float movespeed = 20f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Keyboard.current.upArrowKey.isPressed)
        {
            transform.Translate(0.0f, movespeed * Time.deltaTime, 0);
        }
        else if(Keyboard.current.downArrowKey.isPressed)
        {
            transform.Translate(0.0f, -movespeed * Time.deltaTime, 0);
        }
        if(Keyboard.current.leftArrowKey.isPressed)
        {
            transform.Translate(-steerspeed * Time.deltaTime, 0, 0);
        }
        else if(Keyboard.current.rightArrowKey.isPressed)
        {
            transform.Translate(+steerspeed * Time.deltaTime, 0, 0);
        }
    }
}
