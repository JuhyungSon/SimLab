using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeChecker : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        UnityEngine.Debug.Log(System.DateTime.Now.ToLongTimeString() + " : ");
        Debug.Log("User come to valve closely time");
    }
}
