using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorSet : MonoBehaviour
{

    [SerializeField] Colors colors;
    [SerializeField] GameObject ButtonColors;

    private void Awake()
    {

        string Nome = PlayerPrefs.GetString("Nome");
        print(Nome);
        string Scuola = PlayerPrefs.GetString(Nome + ".Scuola");

        print(Scuola);

        switch (Scuola)
        {
            case "Red":
                colors.material.SetColor("_PrimaryColor", colors.colors[4]);
                colors.material.SetColor("_SecondaryColor", colors.colors[2]);
                ButtonColors.SetActive(false);

                break;
            case "Big_Wave":
                colors.material.SetColor("_PrimaryColor", colors.colors[3]);
                colors.material.SetColor("_SecondaryColor", colors.colors[2]);
                ButtonColors.SetActive(false);

                break;
            case "Big_Rock":
                colors.material.SetColor("_PrimaryColor", colors.colors[0]);
                colors.material.SetColor("_SecondaryColor", colors.colors[2]);
                ButtonColors.SetActive(false);

                break;
            case "H-farm_School":
                colors.material.SetColor("_PrimaryColor", colors.colors[4]);
                colors.material.SetColor("_SecondaryColor", colors.colors[1]);
                ButtonColors.SetActive(false);

                break;
            case "H-farm_College":
                colors.material.SetColor("_PrimaryColor", colors.colors[0]);
                colors.material.SetColor("_SecondaryColor", colors.colors[1]);
                ButtonColors.SetActive(false);

                break;
            case "Customize":
                colors.material.SetColor("_PrimaryColor", colors.colors[1]);
                colors.material.SetColor("_SecondaryColor", colors.colors[1]);
                ButtonColors.SetActive(true);
                break;
        }

    }
}
