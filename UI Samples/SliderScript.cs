using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScript : MonoBehaviour
{

    public Slider _slider;

    public void Alterar()
    {
        Debug.Log(_slider.value);
    }
}
