﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSAim : MonoBehaviour {

    float mouseX;
    float mouseY;
    public bool IntervedMouse;

    // Use this for initialization
    void Start () {
		
	}

    // Update is called once per frame
    void Update() {
        //   Vector3 mousePosition = Input.mousePosition;
        //Debug.Log(mousePosition);
        //float mouseX = mousePosition.x;

        // Debug.Log("mouseX");
        //     float mouseY = mousePosition.y;
        //  Debug.Log(transform.localRotation);
        //  Debug.Log(transform.localEulerAngles);
        //  transform.eulerAngles = new Vector3(mouseY, 0, 0);
        //mouseY += Input.GetAxis("Mouse Y");
        mouseX += Input.GetAxis("Mouse X");
        if (IntervedMouse)
        {
            mouseY += Input.GetAxis("Mouse Y");
        }
        else
        {
            mouseY -= Input.GetAxis("Mouse Y");
        }
        Debug.Log(mouseX);

       
        transform.eulerAngles = new Vector3(mouseY, mouseX, 0);

    }
}
