using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject view;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player")) 
        {
            view.SetActive(true);
            var videoPlayer = GameObject.FindGameObjectWithTag("Finish").GetComponent<UnityEngine.Video.VideoPlayer>();
            videoPlayer.Play();
        }
        
    }
}
