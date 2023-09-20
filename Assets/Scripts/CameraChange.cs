using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraChange : MonoBehaviour
{
    public Vector3 startCameraPos;
    public Vector3 targetPosition1;  // X = 18,5
    public Vector3 targetPosition2; // X = 37.5

    public GameObject MainCamera;

    public void StartCameraPosition()
    {
        MainCamera.transform.position = startCameraPos;
    }
    public void ChangeCameraPosition1()
    {
        MainCamera.transform.position = targetPosition1;
        Debug.Log("holaholitaa");
    }

    public void ChangeCameraPosition2()
    {
        MainCamera.transform.position = targetPosition2;
    }
}
