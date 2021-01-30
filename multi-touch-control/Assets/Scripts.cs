﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    Touch touch;
    Vector3 touchPosition;
    private void Update()
    {
        for (int i = 0; i < Input.touchCount; i++)
        {
            touchPosition = Camera.main.ScreenToWorldPoint(Input.touches[i].position);
            Debug.DrawLine(Vector3.zero, touchPosition, Color.red);
        }
    }
}
