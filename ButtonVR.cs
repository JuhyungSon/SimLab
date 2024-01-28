using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonVR : MonoBehaviour
{
    public GameObject button;
    public UnityEvent onpress;
    public UnityEvent onRelease;
    GameObject presser;
    bool isPressed;
    public AudioSource buttonSound;
   


    void Start()
    {
        isPressed = false;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (!isPressed)
        {
            button.transform.localPosition = new Vector3(0, 0.003f, 0);
            presser = other.gameObject;
            onpress.Invoke();
            isPressed = true;
            buttonSound.Play();

           

        }
    }
    private void OnTriggerExit(Collider other)
    {
        button.transform.localPosition = new Vector3(0, 0.016f, 0);
        onRelease.Invoke();
        isPressed = false;
    }
}
//
