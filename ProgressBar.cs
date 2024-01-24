using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using UnityEngine.EventSystems;

public class ProgressBar : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public VideoPlayer video;
    Slider progressbar;
    bool slide = false;

    void Start()
    {
        progressbar = GetComponent<Slider>();
    }

    public void OnPointerDown(PointerEventData a)
    {
        slide = true;
    }

    public void OnPointerUp(PointerEventData a)
    {
        float frame = (float)progressbar.value * (float)video.frameCount;
        video.frame = (long)frame;
        slide = false;
    }

    void Update()
    {
        if (!slide && video.isPlaying)
        {
            progressbar.value = (float)video.frame / (float)video.frameCount;
        }
    }
}
