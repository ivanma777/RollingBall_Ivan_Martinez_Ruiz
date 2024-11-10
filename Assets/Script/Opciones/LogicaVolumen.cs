using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaVolumen : MonoBehaviour
{
    public Slider slider;
    public float sliderValue;
    public Image imagenMute;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumneAudio", 2f);
        AudioListener.volume = sliderValue;
        RevisarSiEstoyMute();


        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeSlider(float value)
    {

        slider.value = value;
        PlayerPrefs.SetFloat("volumen.Audio",sliderValue);
        AudioListener.volume= slider.value;
        RevisarSiEstoyMute();
    }
    void RevisarSiEstoyMute()
    {


        if (slider.value > 0)
        {

            imagenMute.enabled = true;
        }
        else
        {

            imagenMute.enabled = false; 
        }
    }
}
