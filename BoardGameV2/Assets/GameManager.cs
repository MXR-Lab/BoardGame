using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public VideoPlayer videoPlayer;
    public GameObject enviroment;
    public GameObject button;
    public Canvas c1;
    VideoClipContainer v1;

    void Start()
    {
        videoPlayer.loopPointReached += EnableEnviroment;
    }
    public void PlayVideo(VideoClip vid)
    {
        enviroment.SetActive(false);
        videoPlayer.clip = vid;
        Debug.Log("Video Playing");
    }

    public void videoSelect()
    {
        button.SetActive(true);
    }
    public void videoDeselect()
    {
        button.SetActive(false);
    }

       void EnableEnviroment(VideoPlayer vp)
    {
        enviroment.SetActive(true);
    }
}
