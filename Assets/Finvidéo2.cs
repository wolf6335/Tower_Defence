using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Finvidéo2 : MonoBehaviour
{
    private VideoPlayer m_VideoPlayer;


    void Awake()
    {
        m_VideoPlayer = GetComponent<VideoPlayer>();
        m_VideoPlayer.loopPointReached += OnMovieFinished;// loopPointReached is the event for the end of the video
    }

    void OnMovieFinished(VideoPlayer player)
    {

        Debug.Log("jeu");
        SceneManager.LoadScene("level01");

    }
}