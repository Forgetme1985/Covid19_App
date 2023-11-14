using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginPage : MonoBehaviour
{
    public TextMeshProUGUI textEmail;
    public TextMeshProUGUI textPass;
    public TextMeshProUGUI textMessage;

    private string email;
    private string pass;
    public void Start()
    {
        email = PlayerPrefs.GetString("Email",string.Empty);
        pass = PlayerPrefs.GetString("Password",string.Empty);
    }
    public void Login()
    {
        if (email == string.Empty && pass == string.Empty)
        {
            textMessage.text = "Your account doesn't exist!, please create a new account.";
        }
        else
        {
            Debug.Log("email: " + email + " " + textEmail.text);
            Debug.Log("pass: " + pass + " " + textPass.text);
            if (email == textEmail.text && pass == textPass.text)
            {
                SceneManager.LoadScene("PersonalInformation");
            }
            else
            {
                textMessage.text = "Wrong email or wrong password!";
            }
        }
    }
    public void NewAccount()
    {
        SceneManager.LoadScene("Register");
    }
}