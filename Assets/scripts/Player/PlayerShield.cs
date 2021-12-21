using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using UnityEngine;

public class PlayerShield : MonoBehaviourPun
{
    public bool shieldActive;
    
    // Start is called before the first frame update
    void Start()
    {
        shieldActive = false;
    }

    public void startRoutine(float duration, GameObject shield)
    {
        StartCoroutine(shieldPlayerRoutine( duration, shield));
    }

    public IEnumerator shieldPlayerRoutine(float duration,GameObject shield)
    {
        Debug.Log("here");
        if (photonView.IsMine)
        {
            Destroy(shield);
            setActiveShield(true);
            Debug.Log(shieldActive);
            yield return new WaitForSeconds(duration);
            setActiveShield(false);
            Debug.Log("after shield");
            Debug.Log(shieldActive);
        }
       
    }
    public void setActiveShield(bool value)
    {
        
            shieldActive = value;
        
    }
}
