﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Result : MonoBehaviour
{
    Dictionary<int, int> scores;

    public Text first;
    public Text second;
    public Text third;

    public void SetScores(int minigameIndex, int score)
    {
        scores.Add(minigameIndex, score);
    }
}
