using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbar : MonoBehaviour
{
    public Slider slider;
    public Gradient gradient;
    public Image fill;
    public GameObject losingtext;


    public void setmaxhealth(float health)
    {
        slider.maxValue = health;
        slider.value = health;
        fill.color = gradient.Evaluate(1f);
    }
    public void sethealth(float health)
    {
        health -= 1;
        slider.value = health;
        if (slider.value == 0) { losingtext.SetActive(true); }
        fill.color = gradient.Evaluate(slider.normalizedValue);
    }
    public void damage(int health)
    {
        health -= 1;
    }
    private void Awake()
    {
        losingtext.SetActive(false); 
    }

}

