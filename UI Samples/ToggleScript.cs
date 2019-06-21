using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ToggleScript : MonoBehaviour
{

    public Toggle _toggle;
    private bool isOn = true;
    void FixedUpdate()
    {
        if (isOn)
        {
            Debug.Log("Ligado");
        }
        else
        {
            Debug.Log("Desligado");
        }
    }

    public void AtivarLegendas()
    {
        isOn = _toggle.isOn;
    }
}
