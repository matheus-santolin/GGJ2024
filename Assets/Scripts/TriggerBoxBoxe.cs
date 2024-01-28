using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBoxBoxe : MonoBehaviour
{
    public GameObject boxeGlove;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            boxeGlove.GetComponent<BoxeBox>().ativado = true;
        }
    }
}
