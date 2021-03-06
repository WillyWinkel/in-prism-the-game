﻿using UnityEngine;
using UnityEngine.UI;
using System;

public class LoadStatistics : MonoBehaviour {

    [Header("Text fields")]
    public Text m_PlayTime;
    public Text m_Deaths;
    public Text m_SavedSpheres;


    public void SetActualValues()
    {
        
        SetPlayTime(GlobalStatistics.Instance.GetPlayTime());
        SetDeaths(GlobalStatistics.Instance.GetNumberOfDeath());
    }
	
    public void SetPlayTime(float _time)
    {
        double formatSeconds = TimeSpan.FromSeconds(_time).TotalSeconds;

        double formatMinutes = formatSeconds / 60.0f;

        double formatHours = formatMinutes / 60.0f;

        int totalHours = (int) formatHours;

        int totalMinutes = (int) formatMinutes - (totalHours * 60);

        string playtime = totalHours + " Hours and " + totalMinutes + " Minutes";

        m_PlayTime.text = playtime;

    }

    public void SetDeaths(int _deaths)
    {
        string deaths = _deaths + " Deaths";

        m_Deaths.text = deaths;
    }
}
