using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum LightingMode { On, Blinking, Off }

public class VehicleLightsControl : MonoBehaviour
{
    private void SwitchMainLights(LightingMode mode)
    {
        LightParams parameters = new LightParams(mode, LightType.Main);
        BroadcastMessage("SwitchOnOff", parameters, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchNearLights(LightingMode mode)
    {
        LightParams parameters = new LightParams(mode, LightType.Near);
        BroadcastMessage("SwitchOnOff", parameters, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchSteerRightLights(LightingMode mode)
    {
        LightParams parameters1 = new LightParams(mode, LightType.SteerRight);
        BroadcastMessage("SwitchOnOff", parameters1, SendMessageOptions.DontRequireReceiver);
        LightParams parameters2 = new LightParams(LightingMode.Off, LightType.SteerLeft);
        BroadcastMessage("SwitchOnOff", parameters2, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchSteerLeftLights(LightingMode mode)
    {
        LightParams parameters1 = new LightParams(mode, LightType.SteerLeft);
        BroadcastMessage("SwitchOnOff", parameters1, SendMessageOptions.DontRequireReceiver);
        LightParams parameters2 = new LightParams(LightingMode.Off, LightType.SteerRight);
        BroadcastMessage("SwitchOnOff", parameters2, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchBrakeLights(LightingMode mode)
    {
        LightParams parameters = new LightParams(mode, LightType.Brake);
        BroadcastMessage("SwitchOnOff", parameters, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchFogLights(LightingMode mode)
    {
        LightParams parameters = new LightParams(mode, LightType.Fog);
        BroadcastMessage("SwitchOnOff", parameters, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchEmergencyLights(LightingMode mode)
    {
        LightParams parameters1 = new LightParams(mode, LightType.SteerRight);
        BroadcastMessage("SwitchOnOff", parameters1, SendMessageOptions.DontRequireReceiver);
        LightParams parameters2 = new LightParams(mode, LightType.SteerLeft);
        BroadcastMessage("SwitchOnOff", parameters2, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchReverseLights(LightingMode mode)
    {
        LightParams parameters = new LightParams(mode, LightType.Reverse);
        BroadcastMessage("SwitchOnOff", parameters, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchCargoLights(LightingMode mode)
    {
        LightParams parameters = new LightParams(mode, LightType.Cargo);
        BroadcastMessage("SwitchOnOff", parameters, SendMessageOptions.DontRequireReceiver);
    }

    private void SwitchTrailInteriorLights(LightingMode mode)
    {
        LightParams parameters = new LightParams(mode, LightType.TrailInterior);
        BroadcastMessage("SwitchOnOff", parameters, SendMessageOptions.DontRequireReceiver);
    }
}
