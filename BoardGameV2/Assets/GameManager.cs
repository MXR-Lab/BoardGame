using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class GameManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject enviroment;
    public GameObject button1;

    void Start()
    {
        videoPlayer.loopPointReached += EnableEnviroment;
    }
    public void PlayVideo(string url)
    {
        enviroment.SetActive(false);
        videoPlayer.url = url;
    }

    public void videoSelect()
    {
        button1.SetActive(true);
    }
    public void videoDeselect()
    {
        button1.SetActive(false);
    }

       void EnableEnviroment(VideoPlayer vp)
    {
        enviroment.SetActive(true);
    }
}
