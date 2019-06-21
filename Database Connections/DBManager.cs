using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DBManager : MonoBehaviour
{
    public void TryToRegister(string newUsername, string newEmail, string newPassword)
    {
        StartCoroutine(Register(newUsername, newEmail, newPassword));
        Debug.Log("Trying to register.");
    }

    IEnumerator Register(string username, string email, string password)
    {
        Debug.Log("Registering...");

        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("email", email);
        form.AddField("password", password);

        UnityWebRequest www = UnityWebRequest.Post("http://localhost/sqlapi/register.php", form);
        yield return www.SendWebRequest();

        if(www.downloadHandler.text == "0"){
            Debug.Log("User created succesfull!");
        }

        if(www.isNetworkError || www.isHttpError) {
            Debug.Log(www.error);
        }
    }
}
