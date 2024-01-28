using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabObject : MonoBehaviour
{
    [SerializeField] private GameObject grabObj;
    public Rigidbody _RB;
    public bool alreadyGrabbing = false;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Clicou");
            if (grabObj != null)
            {
                FixedJoint _fj = grabObj.AddComponent<FixedJoint>();
                _fj.connectedBody = _RB;
                _fj.breakForce = 9001;
            }

        } 
        else if (Input.GetMouseButtonUp(0)) 
        {
            Debug.Log("soltou");
            if (grabObj != null) 
            {
                Destroy(grabObj.GetComponent<FixedJoint>());
            }
            grabObj = null;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Grabbable")) 
        {
            grabObj = other.gameObject;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        grabObj = null;
    }
}
