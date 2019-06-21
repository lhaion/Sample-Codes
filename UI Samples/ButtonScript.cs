using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    public Text  _texto;

    public void click()
    {
        _texto.text = "Clicou em mim!";
    }
}
