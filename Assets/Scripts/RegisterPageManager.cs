using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterPageManager : MonoBehaviour
{
    public TextMeshProUGUI textUserName;
    public TextMeshProUGUI textVaccinations;
    public TextMeshProUGUI textAddress;
    public TextMeshProUGUI textBirthDay;
    public TextMeshProUGUI textEmail;
    public TextMeshProUGUI textPassword;
    public TextMeshProUGUI textConfirmPassword;
    public TextMeshProUGUI textMessage;
    public void Register()
    {
        if (textUserName.text == string.Empty || textVaccinations.text == string.Empty || textAddress.text == string.Empty
            || textBirthDay.text == string.Empty || textEmail.text == string.Empty || textPassword.text == string.Empty
            || textConfirmPassword.text == string.Empty)
        {
            textMessage.text = "Please update full information!";
        }
        else
        {
            if (textPassword.text != textConfirmPassword.text)
            {
                textMessage.text = "Password doesn't match confirm password!";
            }
            else
            {
                PlayerPrefs.SetString("UserName", textUserName.text);
                PlayerPrefs.SetString("Password", textPassword.text);
                PlayerPrefs.SetString("Vaccinations", textVaccinations.text);
                PlayerPrefs.SetString("Email", textEmail.text);
                PlayerPrefs.SetString("Birthday", textBirthDay.text);
                PlayerPrefs.SetString("Address", textAddress.text);
                SceneManager.LoadScene("Login");
            }
        }
    }
}
