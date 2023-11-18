using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloInteractive.XR.HoloKit.iOS;

public class LiDARChecker : MonoBehaviour
{
    public void Start()
    {
        Debug.Log($"Support LiDAR {DeviceData.SupportLiDAR()}");
    }
}
