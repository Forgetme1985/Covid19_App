using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PersonalInformationPage : MonoBehaviour
{
    public TextMeshProUGUI textUserName;
    public TextMeshProUGUI textVaccinations;
    public TextMeshProUGUI textAddress;
    public TextMeshProUGUI textBirthDay;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("address: " + PlayerPrefs.GetString("Address"));
        textUserName.text = PlayerPrefs.GetString("UserName");
        textVaccinations.text = PlayerPrefs.GetString("Vaccinations");
        textAddress.text = PlayerPrefs.GetString("Address");
        textBirthDay.text = PlayerPrefs.GetString("Birthday");
    }
}
