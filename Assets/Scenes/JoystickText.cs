using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoystickText : MonoBehaviour
{
      void Start()
    {
        DetectJoysticks();
    }

    void Update()
    {
        // You can call DetectJoysticks in Update if you want to continuously check for joystick changes.
    }

    void DetectJoysticks()
    {
        string[] joystickNames = Input.GetJoystickNames();

        if (joystickNames.Length == 0)
        {
            Debug.Log("No joysticks detected.");
        }
        else
        {
            Debug.Log("Detected Joysticks:");

            for (int i = 0; i < joystickNames.Length; i++)
            {
                Debug.Log("Joystick " + i + ": " + joystickNames[i]);
            }
        }
    }
}