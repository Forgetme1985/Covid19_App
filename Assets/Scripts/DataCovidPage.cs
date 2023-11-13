using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DataCovidPage : MonoBehaviour
{
    public TextMeshProUGUI textDeaths;
    public TextMeshProUGUI textInfections;
    public void Back()
    {
        SceneManager.LoadScene("PersonalInformation");
    }
}
