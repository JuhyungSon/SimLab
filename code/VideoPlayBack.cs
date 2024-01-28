using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoPlayBack : MonoBehaviour
{
    public VideoClip[] videoclips;
    private VideoPlayer videoplayer;
    private int videoClipIndex;

    private void Awake()
    {
        videoplayer = GetComponent<VideoPlayer>();
    }

    // Start is called before the first frame update
    void Start()
    {
        videoplayer.clip = videoclips[0];
    }

    public void playNext()
    {

        videoClipIndex++;
        if (videoClipIndex >= videoclips.Length)
        {
            videoClipIndex = videoClipIndex % videoclips.Length;
        }
        videoplayer.clip = videoclips[videoClipIndex];
        videoplayer.Play();
    }

    public void playPrevious()
    {
        videoClipIndex--;
        if (videoClipIndex <= 0)
        {
            if (videoClipIndex == -1)
            {
                videoClipIndex = videoClipIndex % videoclips.Length + 3;
            }
            videoClipIndex = videoClipIndex % videoclips.Length;
        }
        videoplayer.clip = videoclips[videoClipIndex];
        videoplayer.Play();
    }

    public void Play()
    {
        videoplayer.Play();
    }

    public void Pause()
    {
        videoplayer.Pause();
    }
}
