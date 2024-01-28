using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindBox : MonoBehaviour
{
    public Vector3 windDirection = Vector3.right; // Set the wind direction in the Inspector
    public float windStrength = 10f;
    public float windRadius = 5f;

    void Start()
    {
        
    }

    
    void Update()
    {
        ApplyWindForce();    
    }
    void ApplyWindForce()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, windRadius);

        foreach (Collider collider in colliders)
        {
            Rigidbody rb = collider.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // Apply force to the Rigidbody along the specified wind direction
                rb.AddForce(windDirection.normalized * windStrength, ForceMode.Force);
            }
        }
    }

    private void OnDrawGizmosSelected()
    {
        // Draw a wire sphere in the Unity editor to visualize the wind effect radius
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, windRadius);

        // Draw an arrow to visualize the wind direction
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, windDirection.normalized * windRadius);
    }
}
