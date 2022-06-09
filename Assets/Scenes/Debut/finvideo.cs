using UnityEngine;
using UnityEngine.Video;
using UnityEngine.SceneManagement;

public class finvideo : MonoBehaviour
{
    private VideoPlayer m_VideoPlayer;
    public GameObject Fond;
    public GameObject RawVideo;
    void Awake () 
    {
        m_VideoPlayer = GetComponent<VideoPlayer>();
        m_VideoPlayer.loopPointReached += OnMovieFinished; // loopPointReached is the event for the end of the video
    }

    void OnMovieFinished(VideoPlayer player)
    {
        Debug.Log("Event for movie end called");

        gameObject.SetActive(false);
        RawVideo.SetActive(false);
        Fond.SetActive(true);

    }

}