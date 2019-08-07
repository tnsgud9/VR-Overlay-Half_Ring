using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingManager : OverlayRing 
{

    
    bool overlayToggle=true;



    void Start()
    {
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
            OverayActive();
    }

    void OverayActive()
    {
        overlayToggle = !overlayToggle;
        overlayOBJ.SetActive(overlayToggle);
        
    }
}
