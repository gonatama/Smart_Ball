﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InMouse : MonoBehaviour
{
    public Ray ray;
    [SerializeField] private float MouseX = 0;
    [SerializeField] private float MouseY = 0;
    [SerializeField] private Vector2 MousePos = new Vector2(0.0f, 0.0f);

    //public Vector3 MousePos;
    //public static Vector3 mousePosition;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        if (Input.GetMouseButton(0))
        {
            MouseX += Input.GetAxis("Mouse Y");
            MouseY += Input.GetAxis("Mouse Y");
            MousePos = new Vector2(MouseX, MouseY);
            Debug.Log(MousePos);

        }

        if (Input.GetMouseButtonUp(0))
        {
            Debug.Log(MousePos);

        }
    }

    public float SetMouseSpeed()
    {
        float speed = MousePos.y;
        MousePos = new Vector2(0.0f, 0.0f);
        return speed;
    }
}