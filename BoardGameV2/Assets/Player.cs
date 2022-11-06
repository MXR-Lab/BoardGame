using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameManager manager;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("VideoContainer"))
        {
            VideoClipContainer containerScript = other.GetComponent<VideoClipContainer>();
            manager.PlayVideo(containerScript.videoURL);
        }
    }
}
