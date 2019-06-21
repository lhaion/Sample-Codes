using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuScript : MonoBehaviour
{

    public GameObject _panelConfiguracao;

    public void ExibirMenu(bool _show)
    {
        _panelConfiguracao.SetActive(_show);
    }
}
