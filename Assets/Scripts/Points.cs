using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Points : MonoBehaviour
{
    int points = 0;
    Text pointsText;

    // Start is called before the first frame update
    void Start()
    {
        pointsText = GetComponent<Text>();
        UpdatePoints();
    }

    public void UpdatePoints()
    {
        pointsText.text = points.ToString();
    }

    public void AddPoints(int amount)
    {
        points += amount;
        UpdatePoints();
    }
}
