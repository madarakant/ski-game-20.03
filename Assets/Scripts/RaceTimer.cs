using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaceTimer : MonoBehaviour
{
    private bool timerRunning = false;
    private float raceTime;

    private void OnEnable()
    {
        GameManager.raceStart += StartRaceTimer;
        GameManager.raceFinish += StopRaceTimer;
        GameManager.racePenalty += RacePenalty;
    }
    private void OnDisable()
    {
        GameManager.raceStart -= StartRaceTimer;
        GameManager.raceFinish -= StopRaceTimer;
        GameManager.racePenalty -= RacePenalty;

    }

    private void StartRaceTimer()
    {
        timerRunning = true;
        print("race started");
    }

    private void StopRaceTimer()
    {
        timerRunning = false;
        print("Race finished. Race time: " + raceTime);
    }

    private void RacePenalty()
    {
        
    }

    private void Update()
    {
        if (timerRunning)
        {
            raceTime += Time.deltaTime;
        }
    }
}
