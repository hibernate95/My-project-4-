using UnityEngine;
using UnityEngine.UI;
using System;

public class DisplayTime : MonoBehaviour
{
    public Text timeText;

    private void Update()
    {
        timeText.text = DateTime.Now.ToString("HH:mm");
    }
}
