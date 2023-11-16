using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RegisterPage : MonoBehaviour
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
                string userName = PlayerPrefs.GetString("UserName", string.Empty);
                string password = PlayerPrefs.GetString("Password", string.Empty);
                string vaccinations = PlayerPrefs.GetString("Vaccinations", string.Empty);
                string email = PlayerPrefs.GetString("Email", string.Empty);
                string birthday = PlayerPrefs.GetString("Birthday", string.Empty);
                string address = PlayerPrefs.GetString("Address", string.Empty);
                if (string.IsNullOrEmpty(userName) && string.IsNullOrEmpty(password))
                {
                    PlayerPrefs.SetString("UserName", textUserName.text);
                    PlayerPrefs.SetString("Password", textPassword.text);
                    PlayerPrefs.SetString("Vaccinations", textVaccinations.text);
                    PlayerPrefs.SetString("Email", textEmail.text);
                    PlayerPrefs.SetString("Birthday", textBirthDay.text);
                    PlayerPrefs.SetString("Address", textAddress.text);
                }
                else
                {
                    PlayerPrefs.SetString("UserName",userName + "," + textUserName.text);
                    PlayerPrefs.SetString("Password",password + "," +  textPassword.text);
                    PlayerPrefs.SetString("Vaccinations",vaccinations + "," + textVaccinations.text);
                    PlayerPrefs.SetString("Email", email + "," + textEmail.text);
                    PlayerPrefs.SetString("Birthday", birthday + "," + textBirthDay.text);
                    PlayerPrefs.SetString("Address",address + "," + textAddress.text);
                }
                
                SceneManager.LoadScene("Login");
            }
        }
    }
}
