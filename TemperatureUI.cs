using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TemperatureUI : MonoBehaviour
{
    public Temperature temperature;
    public TextMeshProUGUI temperatureText;
    

    // Update is called once per frame
    void Update()
    {
        float roundTemperature = Mathf.Round(temperature.temperatureCurrent * 10.0f) * 0.1f;
        temperatureText.text = roundTemperature.ToString();
    }
}
