using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

    public class InteralTimer
    {
        public delegate void OnTimerCompleteAction();
        public event OnTimerCompleteAction onTimerComplete;

        private float timeRemaining, originalTimer;
        private bool timerRunning = false;
        private OnTimerCompleteAction subscribedAction;

        public void StartTimer(float _timeInSeconds, OnTimerCompleteAction _timerCompletedSubscriber)
        {
            if (!timerRunning)
            {
                originalTimer = _timeInSeconds;
                timeRemaining = _timeInSeconds;
                Debug.LogFormat("Beginning timer with {0} seconds on the clock", timeRemaining);
                subscribedAction = _timerCompletedSubscriber;
                onTimerComplete += subscribedAction;
                timerRunning = true;
            }
            else
            {
                Debug.LogWarningFormat("Timer is already running with {0} seconds remaining, please use ResetTimer() or StopTimer() if you wish to modify or cancel", timeRemaining);
            }
        }

        public void ResetTimer()
        {
            if (timerRunning)
            {
                timeRemaining = originalTimer;
            }
            else
            {
                Debug.LogWarning("Timer is not currently running. Please use StartTimer()");
            }
        }

        public void CancelTimer()
        {
            if (timerRunning)
            {
                timerRunning = false;
                onTimerComplete -= subscribedAction;
            }
            else
            {
                Debug.LogWarning("Timer is not currently running. Please use StartTimer()");
            }
        }

        public bool IsTimerActive()
        {
            return timerRunning;
        }

        private bool TimerTick()
        {
            timeRemaining -= Time.deltaTime;
            return timeRemaining <= 0;
        }

        public void UpdateTimer()
        {
            if (timerRunning)
            {
                if (TimerTick())
                {
                    Debug.LogFormat("Timer complete");
                    timerRunning = false;
                    onTimerComplete?.Invoke();
                    onTimerComplete -= subscribedAction;
                }
            }
        }
    }

