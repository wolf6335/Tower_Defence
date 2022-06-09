using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Finvidéo2 : MonoBehaviour
{
    private VideoPlayer m_VideoPlayer;
     public VideoPlayer.EventHandler OnMovieFinished { get; private set; }

    void Awake()
    {
        m_VideoPlayer = GetComponent<VideoPlayer>();
        m_VideoPlayer.loopPointReached += OnMovieFinished; // loopPointReached is the event for the end of the video
    }

    public void Scene1()
    {
        SceneManager.LoadScene("level01");
    }

}