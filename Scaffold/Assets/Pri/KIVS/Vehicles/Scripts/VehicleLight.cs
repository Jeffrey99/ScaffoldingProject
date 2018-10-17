using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LightType { SteerLeft, SteerRight, Main, Brake, Reverse, Cargo, TrailInterior, Fog, Near }

public class LightParams
{
    public LightingMode mode;
    public LightType type;
    public LightParams(LightingMode _mode, LightType _type)
    {
        mode = _mode;
        type = _type;
    }
}

public class VehicleLight : MonoBehaviour
{
    [SerializeField]
    private LightType lightType;
    [SerializeField]
    private Light[] lightSources;
    [Range(0, 1)]
    [SerializeField]
    private float blinkRate = 0.42f;

    bool isOn = false;
    bool isBlinking = false;
    Renderer rend;
    float blinkTimer;

    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    public void SwitchOnOff(LightParams param)
    {
        if (param.type == lightType)
        {
            switch (param.mode)
            {
                case LightingMode.On:
                    isOn = true;
                    isBlinking = false;
                    blinkTimer = blinkRate;
                    break;
                case LightingMode.Blinking:
                    isOn = false;
                    isBlinking = true;
                    blinkTimer = blinkRate;
                    break;
                case LightingMode.Off:
                    isOn = false;
                    isBlinking = false;
                    break;
            }
        }
    }

    void Update()
    {
        if (isBlinking)
        {
            if (blinkTimer >= blinkRate)
            {
                isOn = !isOn;
                blinkTimer = 0f;
            }
            else
                blinkTimer += Time.deltaTime;
        }

        if (isOn)
        {
            rend.enabled = true;
            if (lightSources.Length > 0)
            {
                foreach (var ls in lightSources)
                {
                    ls.enabled = true;
                }
            }
        }
        else
        {
            rend.enabled = false;
            if (lightSources.Length > 0)
            {
                foreach (var ls in lightSources)
                {
                    ls.enabled = false;
                }
            }
        }
    }
}
