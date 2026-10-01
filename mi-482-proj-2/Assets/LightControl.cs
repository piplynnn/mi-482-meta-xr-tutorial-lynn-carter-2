using Meta.XR.ImmersiveDebugger.UserInterface.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LightControl : MonoBehaviour
{
    public Light[] lights;
    public float maxIntensity = 2.0f;
    public UnityEngine.UI.Toggle toggle;
    public UnityEngine.UI.Slider slider;

    private void Update()
    {
        foreach(Light l in lights)
        {
            if (toggle.isOn) {
                l.intensity = slider.value * maxIntensity;
            } else {
                l.intensity = 0;
            }
        }
    }
}