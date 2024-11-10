using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaBrillo : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image PanelBrillo;
    // Start is called before the first frame update
    void Start()
    {
        
        slider.value = PlayerPrefs.GetFloat("brillo", 1f);
        PanelBrillo.color = new Color(PanelBrillo.color.r, PanelBrillo.color.g, PanelBrillo.color.b, slider.value);

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSlider(float value)
    {
        sliderValue = value;
        slider.value = PlayerPrefs.GetFloat("brillo", sliderValue);
        PanelBrillo.color = new Color(PanelBrillo.color.r, PanelBrillo.color.g, PanelBrillo.color.b, slider.value);


    }
}
