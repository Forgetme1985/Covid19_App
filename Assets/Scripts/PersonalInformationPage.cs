using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PersonalInformationPage : MonoBehaviour
{
    public TextMeshProUGUI textUserName;
    public TextMeshProUGUI textVaccinations;
    public TextMeshProUGUI textAddress;
    public TextMeshProUGUI textBirthDay;
    // Start is called before the first frame update
    void Start()
    {
       
        textUserName.text = new List<string>( PlayerPrefs.GetString("UserName").Split(","))[LoginPage.indexUser];
        textVaccinations.text = new List<string>( PlayerPrefs.GetString("Vaccinations").Split(","))[LoginPage.indexUser];
        textAddress.text = new List<string>(PlayerPrefs.GetString("Address").Split(","))[LoginPage.indexUser];
        textBirthDay.text = new List<string>(PlayerPrefs.GetString("Birthday").Split(","))[LoginPage.indexUser];
    }
    public void Report()
    {
        SceneManager.LoadScene("Report");
    }
    public void CovidData()
    {
        SceneManager.LoadScene("Data");
    }
    public void Signout()
    {
        SceneManager.LoadScene("Login");
    }
}
