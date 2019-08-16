using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.XR;
using Valve.VR;

public class OverlayRing : MonoBehaviour
{
    public GameObject carmeraInspector;
    public GameObject overlayInspector;

    public static GameObject carmera;
    public static GameObject overlayOBJ;
    void Awake () {
        carmera = carmeraInspector;
        overlayOBJ = overlayInspector;
    }

    //Important : It is handled first. (Maximum Priority in define to Script Execution Order)
    //중요 : 가장 먼저 처리된다.( 최고 우선 순위로 Script Execution Order에 지정되어 있다. )
    void Update () {
        //Debug.Log("HMD Rotation : " + carmera.transform.eulerAngles);
        overlayOBJ.gameObject.transform.rotation = Quaternion.Euler(0 , 0, 360f-carmera.transform.eulerAngles.z);


    }



}
