using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SignUp : MonoBehaviour
{
    public InputField userField;
    public InputField emailField;
    public InputField passField;
    public InputField confirmPassField;
    public DBManager dbmanager;

    public void CreateNewUser()
    {
        dbmanager.TryToRegister(userField.text, emailField.text, passField.text);
    }
}
