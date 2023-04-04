using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SliderListener : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Slider slider;

    [SerializeField]
    private SpinMe spinner;

    private void Start()
    {
        slider.value = slider.maxValue * .25f;
    }

    public void SliderValueChanged()
    {
        spinner.SetSpeed(slider.value);
    }
}
