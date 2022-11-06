using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;


    public void PlayVideo(string url)
    {
        videoPlayer.url = url;
    }    
}
