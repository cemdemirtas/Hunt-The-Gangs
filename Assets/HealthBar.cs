using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    private Camera cam;
    private void OnEnable()
    {
        cam = Camera.main;
    }
    private void LateUpdate()
    {
        if (cam != null) transform.LookAt(cam.transform);
    }
}
