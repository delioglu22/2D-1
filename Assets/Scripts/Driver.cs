using System;
using UnityEngine;
using UnityEngine.InputSystem;
using TMPro;

public class Driver : MonoBehaviour
{
    [SerializeField] float steerspeed = 200f;
    [SerializeField] float currentspeed = 10f;
    [SerializeField] float boostspeed = 15f;
    [SerializeField] float normalspeed = 10f;
    [SerializeField] TMP_Text BoostText;

    void Start()
    {
        BoostText.gameObject.SetActive(false);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Boost"))
        {
            Debug.Log("Hit Boost");
            currentspeed = boostspeed;
            BoostText.gameObject.SetActive(true);
            Destroy(collision.gameObject, 0.1f);
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("bump"))
        {
            Debug.Log("Hit Normal Speed");
            currentspeed = normalspeed;
            BoostText.gameObject.SetActive(false);
        }
    }
    void Update()
    {
        float move = 0f;
        float steer = 0f;

        if(Keyboard.current.upArrowKey.isPressed)
        {
            move = -1f;
        }
        else if(Keyboard.current.downArrowKey.isPressed)
        {
            move = 1f;
        }
        if(Keyboard.current.leftArrowKey.isPressed)
        {
            steer = 1f;
        }
        else if(Keyboard.current.rightArrowKey.isPressed)
        {
            steer = -1f;
        }

        float amountToMove = move * currentspeed * Time.deltaTime;
        float amountToSteer = steer * steerspeed * Time.deltaTime;

        transform.Translate(0.0f, amountToMove, 0);
        transform.Rotate(0, 0, amountToSteer);


    }
}
