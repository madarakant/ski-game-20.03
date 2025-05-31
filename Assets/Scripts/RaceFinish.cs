using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceFinish : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.CallRaceFinish();
            
        }
    }
}
