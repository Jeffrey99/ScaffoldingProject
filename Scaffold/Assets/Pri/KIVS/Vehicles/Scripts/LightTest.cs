using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightTest : MonoBehaviour 
{
    public GameObject[] vehicles;

    void OnGUI()
    {
        //Main lights
        if (GUI.Button(new Rect(10, 10, 100, 20), "+ main"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchMainLights", LightingMode.On, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 10, 100, 20), "- main"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchMainLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Near lights
        if (GUI.Button(new Rect(10, 30, 100, 20), "+ near"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchNearLights", LightingMode.On, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 30, 100, 20), "- near"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchNearLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Steerright lights
        if (GUI.Button(new Rect(10, 50, 100, 20), "+ steer rght."))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchSteerRightLights", LightingMode.Blinking, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 50, 100, 20), "- steer rght."))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchSteerRightLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Steerleft lights
        if (GUI.Button(new Rect(10, 70, 100, 20), "+ steer lft."))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchSteerLeftLights", LightingMode.Blinking, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 70, 100, 20), "- steer lft."))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchSteerLeftLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Brake lights
        if (GUI.Button(new Rect(10, 90, 100, 20), "+ brake"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchBrakeLights", LightingMode.On, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 90, 100, 20), "- brake"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchBrakeLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Fog lights
        if (GUI.Button(new Rect(10, 110, 100, 20), "+ fog"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchFogLights", LightingMode.On, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 110, 100, 20), "- fog"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchFogLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Emergency lights
        if (GUI.Button(new Rect(10, 130, 100, 20), "+ emerg"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchEmergencyLights", LightingMode.Blinking, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 130, 100, 20), "- emerg"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchEmergencyLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Reverse lights
        if (GUI.Button(new Rect(10, 150, 100, 20), "+ revers"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchReverseLights", LightingMode.On, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 150, 100, 20), "- revers"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchReverseLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Cargo lights
        if (GUI.Button(new Rect(10, 170, 100, 20), "+ cargo"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchCargoLights", LightingMode.On, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 170, 100, 20), "- cargo"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchCargoLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }

        //Trail interior lights
        if (GUI.Button(new Rect(10, 190, 100, 20), "+ interior"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchTrailInteriorLights", LightingMode.On, SendMessageOptions.DontRequireReceiver);
        }
        if (GUI.Button(new Rect(110, 190, 100, 20), "- interior"))
        {
            foreach (var item in vehicles)
                item.BroadcastMessage("SwitchTrailInteriorLights", LightingMode.Off, SendMessageOptions.DontRequireReceiver);
        }
    }
}
