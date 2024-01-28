using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class MoveScene : MonoBehaviour
{
  public void moveScene()
    {
        PhotonNetwork.LoadLevel(3);
    }
}
