using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject enviroment;

    void Start()
    {
        videoPlayer.loopPointReached += EnableEnviroment;
    }
    public void PlayVideo(string url)
    {
        enviroment.SetActive(false);
        videoPlayer.url = url;
    }    

    void EnableEnviroment(VideoPlayer vp)
    {
        enviroment.SetActive(true);
    }
}
