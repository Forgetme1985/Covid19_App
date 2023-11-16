using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoginPage : MonoBehaviour
{
    [HideInInspector]
    public static int indexUser;

    public TextMeshProUGUI textEmail;
    public TextMeshProUGUI textPass;
    public TextMeshProUGUI textMessage;

    private List<string> emails = new List<string>();
    private List<string> passes = new List<string>();
    public void Start()
    {
        indexUser = -1;
        emails = new List<string>(PlayerPrefs.GetString("Email",string.Empty).Split(","));
        passes = new List<string>(PlayerPrefs.GetString("Password",string.Empty).Split(","));
    }
    public void Login()
    {
        if (emails.Count == 0 && passes.Count == 0)
        {
            textMessage.text = "Your account doesn't exist!, please create a new account.";
        }
        else
        {

            indexUser = emails.FindIndex(e => e == textEmail.text);
            if (indexUser >= 0 && passes.FindIndex(p=>p == textPass.text) >= 0)
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
