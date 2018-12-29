using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Options : MonoBehaviour
{
    public Light light;
    
    public void shadowSwitch(bool newValue)
    {
        light.shadows = newValue ? LightShadows.Soft : LightShadows.None;
    }
}