using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputScript : MonoBehaviour
{

    public InputField _usuario;
    public InputField _senha;

    public void Entrar()
    {
        //string usuario = _usuario.text;//Obtemos uma informação
        string dadosUsuario = string.Format("Usuário {0} Senha {1}", _usuario.text, _senha.text);
        Debug.Log(dadosUsuario);
    }
}
