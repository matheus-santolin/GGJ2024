using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CopyMotion : MonoBehaviour
{
    public Transform targetLimb;
    ConfigurableJoint _CJ;
    void Start()
    {
        _CJ = GetComponent<ConfigurableJoint>();
    }

   
    void Update()
    {
        _CJ.targetRotation = targetLimb.rotation;
    }
}
