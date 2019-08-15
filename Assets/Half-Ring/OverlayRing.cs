using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;
using Valve.VR;

public class OverlayRing : MonoBehaviour
{

    public GameObject carmera;
    public GameObject overlayOBJ;
    void Start () {
    }
	
	void Update () {
        Debug.Log("HMD Rotation : " + carmera.transform.eulerAngles);
        overlayOBJ.gameObject.transform.rotation = Quaternion.Euler(0 , 0, 360f-carmera.transform.eulerAngles.z);

    }



}
