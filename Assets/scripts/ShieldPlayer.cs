using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldPlayer : MonoBehaviour
{
    PlayerShield shield;
    [SerializeField] float duration = 5f;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            shield = other.GetComponent<PlayerShield>();
            Debug.Log("before routine");
            shield.startRoutine(duration,this.gameObject);
        }
    }

}
