using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityRawInput;

public class SettingManager : MonoBehaviour 
{
    public static int ImageCode;
    public static int ColorCode;

    public static bool RawInputService = true;
    public static bool OverlayToggle = true;
    public static bool UpLowToggle = true;


    public GameObject overlayInspector;

    void Awake()
    {
        RawKeyInput.Start(RawInputService);
        Screen.SetResolution(640, 480, false);
    }

    void Update()
    {
        // RawKeyInput.OnKeyUp += OverayActive(Space);
        // if (RawKeyInput.IsKeyDown(RawKey.Space)) OverayActive();

        if ((OverlayRing.carmera.gameObject.transform.rotation.x * 10 <= -3.7f ||
             OverlayRing.carmera.gameObject.transform.rotation.x * 10 >= 4f)   && UpLowToggle == true)
            OverlayRing.overlayOBJ.SetActive(false);
        else
            OverlayRing.overlayOBJ.SetActive(OverlayToggle);

    }

    public void OverayActive()
    {
        OverlayToggle = !OverlayToggle;
        OverlayRing.overlayOBJ.SetActive(OverlayToggle);
    }

    public void PovUpperLowerCheck()
    {
        UpLowToggle = !UpLowToggle;
        OverlayRing.overlayOBJ.SetActive(UpLowToggle);
    }

    public static void OverlayChange()
    {

    }






    private void OnApplicationQuit()
    {
        RawKeyInput.Start(false);
        RawKeyInput.Stop();

    }
}
