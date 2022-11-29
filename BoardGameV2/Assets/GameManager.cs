using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;
using Photon.Pun;

public class GameManager : MonoBehaviourPun
{
    public VideoPlayer videoPlayer;
    public GameObject enviroment;
    public GameObject button;
    public Canvas c1;
    VideoClipContainer v1;
    [SerializeField] Material mat;
    [SerializeField] Material mat2;
    public VideoClip vid;

    void Start()
    {
        videoPlayer.loopPointReached += EnableEnviroment;
    }

    public void PlayVideo(VideoClip video)
    {
            vid = video;
            PhotonView photonView = PhotonView.Get(this);
            photonView.RPC("runVideo", RpcTarget.All);
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
        RenderSettings.skybox = mat;
    }

    [PunRPC]
    void runVideo()
    {
        //vid = video;
        enviroment.SetActive(false);
        RenderSettings.skybox = mat2;
        videoPlayer.clip = vid;
        videoPlayer.Play();
    }

}

