using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DropDownScript : MonoBehaviour {
    public Dropdown _dropDown;
    public void AlterarIdioma()
    {
        Debug.Log(_dropDown.value); //get value
    }
}
