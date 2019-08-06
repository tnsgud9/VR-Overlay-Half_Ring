using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BoardingRing : MonoBehaviour
{
    Vector3 gryo_rotation;
    // Use this for initialization
	void Start () {
        Input.gyro.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
        gryo_rotation.x += Input.gyro.rotationRateUnbiased.x;

        gryo_rotation.y += Input.gyro.rotationRateUnbiased.y;
        gryo_rotation.z += Input.gyro.rotationRateUnbiased.z;
    }

}
