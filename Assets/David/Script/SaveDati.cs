using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class SaveDati : MonoBehaviour
{
    [SerializeField] TMP_InputField TMP_InputField_Name;
    [SerializeField] TMP_InputField TMP_InputField_Surname;
    [SerializeField] TMP_InputField TMP_InputField_Email;

    [SerializeField] string Scuola_Scelta;

    [SerializeField] Button Button_Start;

    [SerializeField] string[] ElementeCheck = {".com",".gov",".it"};
    [SerializeField] bool ContainEmail = false;

    private void Awake()
    {
        Load_Dati();
    }

    public void valid_Object()
    {
        foreach (string StringE in ElementeCheck)
        {
            if (TMP_InputField_Email.text.Contains(StringE) && TMP_InputField_Email.text.Contains("@"))
            {
                ContainEmail = true;
                break;
            }
            else 
            {
                ContainEmail = false;
            }
        }

        if (TMP_InputField_Name.text == "" || TMP_InputField_Surname.text == "" || ContainEmail == false || TMP_InputField_Email.text == "")
        {
            Button_Start.interactable = false;
        }
        else
        {
            Button_Start.interactable = true;
        }
    }

    public void Scelta_Scuola(string scuola_N)
    {
        Scuola_Scelta = scuola_N;
    }

    public void save_dati()
    {

        PlayerPrefs.SetString("Nome", TMP_InputField_Name.text);
        string Surname = TMP_InputField_Name.text + ".Surname";
        PlayerPrefs.SetString(Surname, TMP_InputField_Surname.text);
        string Email = TMP_InputField_Name.text + ".Email";
        PlayerPrefs.SetString(Email, TMP_InputField_Email.text);
        string Scuola = TMP_InputField_Name.text + ".Scuola";
        PlayerPrefs.SetString(Scuola, Scuola_Scelta);

    }

    public void Load_Dati()
    {
        string Name = PlayerPrefs.GetString("Nome");
        if (Name != "")
        {
            TMP_InputField_Name.text = Name;
            TMP_InputField_Surname.text = PlayerPrefs.GetString(Name + ".Surname");
            TMP_InputField_Email.text = PlayerPrefs.GetString(Name + ".Email");
        }
        valid_Object();
    }

    [ContextMenu("Canc Dati")]
    public void Canc()
    {
        PlayerPrefs.DeleteAll();
    }
}
