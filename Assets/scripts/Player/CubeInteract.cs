using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;
using Com.MyCompany.MyGame;

public class CubeInteract : MonoBehaviourPun
{
    [SerializeField] string triggeringTag;
    public GameObject text;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == triggeringTag && photonView.IsMine)
        {
            text.SetActive(true);
        }
    }
   
    
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == triggeringTag && photonView.IsMine)
        {
            text.SetActive(false);
        }
    }
}
