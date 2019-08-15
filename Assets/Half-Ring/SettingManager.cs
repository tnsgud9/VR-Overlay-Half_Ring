using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRawInput;

public class SettingManager : OverlayRing 
{


    public static bool RawInputService = true;
    bool overlayToggle=true;

    void Awake()
    {
        RawKeyInput.Start(RawInputService);
        Screen.SetResolution(640, 480, false);
    }

    void Update()
    {
       // RawKeyInput.OnKeyUp += OverayActive(Space);
        if (RawKeyInput.IsKeyDown(RawKey.Space)) OverayActive();
    }

    void OverayActive()
    {
        overlayToggle = !overlayToggle;
        overlayOBJ.SetActive(overlayToggle);
    }

    private void OnApplicationQuit()
    {
        RawKeyInput.Start(false);
        RawKeyInput.Stop();

    }
}
