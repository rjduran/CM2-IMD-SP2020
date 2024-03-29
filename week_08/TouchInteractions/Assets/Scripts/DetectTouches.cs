﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DetectTouches : MonoBehaviour
{
    public Text m_Text;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        var fingerCount = 0;

        foreach (Touch touch in Input.touches)
        {           
            if (touch.phase != TouchPhase.Ended && touch.phase != TouchPhase.Canceled)
            {
                fingerCount++;
                m_Text.text =
                    "fingerCount: " + fingerCount + "\n" +
                    "touch (" + touch.fingerId + "): \n" +
                    "  touch.position: " + touch.position + "\n" +
                    "  touch.pressure: " + touch.pressure + "\n" +
                    "  touch.radius: " + touch.radius + "\n";
            }

        }        

    }
}
