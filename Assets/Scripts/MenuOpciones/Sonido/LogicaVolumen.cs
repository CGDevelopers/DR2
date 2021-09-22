using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicaSonido : MonoBehaviour
{
    public Slider slider;
    public float SliderValue;

    void Start()
    {
        slider.value = PlayerPrefs.GetFloat("volumenAudio", 0.5f);
        AudioListener.volume = slider.value;
        



    }

    public void ChangeSlider(float valor)
    {
        SliderValue = valor;
        PlayerPrefs.SetFloat("volumenAudio", SliderValue);
        AudioListener.volume = slider.value;
    }

}
