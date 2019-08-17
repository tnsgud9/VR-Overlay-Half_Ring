using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityRawInput;

[System.Serializable]
public class ImgTexture
{
    public Texture[] TexColor;
}

public class SettingManager : OverlayRing 
{
    public Text StatusNotice;
    public ImgTexture[] Options;

    public static int ImageCode=0;
    public static int ColorCode=2;

    public static bool RawInputService = true;
    public static bool OverlayToggle = true;
    public static bool UpLowToggle = true;



    void Awake()
    {
        RawKeyInput.Start(RawInputService);
        Screen.SetResolution(640, 480, false);
    }

    void Update()
    {
        // RawKeyInput.OnKeyUp += OverayActive(Space);
        // if (RawKeyInput.IsKeyDown(RawKey.Space)) OverayActive();

        if ((carmera.gameObject.transform.rotation.x * 10 <= -3.7f ||
             carmera.gameObject.transform.rotation.x * 10 >= 4f)   && UpLowToggle == true)
            overlayOBJ.SetActive(false);
        else
            overlayOBJ.SetActive(OverlayToggle);

    }

    public void OverayActive()
    {
        OverlayToggle = !OverlayToggle;
        overlayOBJ.SetActive(OverlayToggle);
    }

    public void PovUpperLowerCheck()
    {
        UpLowToggle = !UpLowToggle;
        overlayOBJ.SetActive(UpLowToggle);
    }


    public void OverlayChange()
    {
        overlayOBJ.GetComponent<HOTK_Overlay>().OverlayTexture = Options[ImageCode].TexColor[ColorCode];
    }


    private void OnApplicationQuit()
    {
        RawKeyInput.Start(false);
        RawKeyInput.Stop();

    }
}

