using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReportPage : MonoBehaviour
{
    public TextMeshProUGUI textUserName;
    public TextMeshProUGUI textAddress;
    public TextMeshProUGUI textMessage;
    public void Rerport()
    {
        if (textUserName.text == string.Empty || textAddress.text == string.Empty)
        {
            textMessage.text = "Please update full information!";
        }
        else
        {

            PlayerPrefs.SetString("UserNameReport", textUserName.text);
            PlayerPrefs.SetString("AddressReport", textAddress.text);
            textMessage.text = "Your report was sent!";
        }
    }
    public void Back()
    {
        SceneManager.LoadScene("PersonalInformation");
    }
}
