using System;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public class Options : MonoBehaviour
{
    public Boolean shadow;
    public DirectionalLight MAZELIGHT;
    
    public void ShadowSwitch()
    {
        if (shadow)
        {
           // MAZELIGHT = GetComponent(LightShadows.Soft);
        }
        
        else
        {
           // MAZELIGHT = GetComponent(LightShadows.None);
        }
    }
}