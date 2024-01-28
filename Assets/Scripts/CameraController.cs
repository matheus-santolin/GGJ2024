using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public Transform root;

    float mouseX, mouseY;

    public float offSet;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;    
    }

    private void FixedUpdate()
    {
        CamControl();
    }

    void CamControl() 
    {
        
    }
}
