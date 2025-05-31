using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PenaltyFlag : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            GameEvents.CallRacePenalty();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
