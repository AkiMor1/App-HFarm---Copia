using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class loadDatiCarrello : MonoBehaviour
{
    
    private string Jakect;
    [SerializeField]private float Prezzo;
    private string Size;
    private int Quantit� = 1;
    [SerializeField] private Sprite[] img;

    [SerializeField] private Image zoneImg;
    [SerializeField] private TMPro.TMP_Text TextJacket;
    [SerializeField] private TMPro.TMP_Text TextPrezzo;
    [SerializeField] private TMPro.TMP_Text TextSize;
    [SerializeField] private TMPro.TMP_Text TextQuantit�;


    private void Awake()
    {
        GetInfo();
    }


    [ContextMenu("Aggiorna Info")]
    public void GetInfo()
    {
        string Name = PlayerPrefs.GetString("Nome");
        string Size = PlayerPrefs.GetString(Name + ".Size");
        string NameJaket = PlayerPrefs.GetString(Name + ".Scuola");
        

        TextJacket.text = "Jacket: " + NameJaket;
        TextPrezzo.text = (Prezzo* Quantit�).ToString()+" �";
        TextSize.text = "Size: " + Size;
        TextQuantit�.text = "Quantity: " + Quantit�;

        print(NameJaket);

        switch (NameJaket)
        {
            case "Big_Rock":
                zoneImg.sprite = img[0];
                break;
            case "Big_Wave":
                zoneImg.sprite = img[1];
                break;
            case "H-farm_School":
                zoneImg.sprite = img[2];
                break;
            case "H-farm_College":
                zoneImg.sprite = img[3];
                break;
            case "Red":
                zoneImg.sprite = img[4];
                break;
            case "Customize":
                zoneImg.sprite = img[5];
                break;
        }
             
       
    }

    public void ButtonQuantit�(bool Add)
    {
        if (Add)
        {
            Quantit�++;
        }
        else
        {
            Quantit�--;
            if (Quantit� < 1)
            {
                Quantit� = 1;
            }
        }
        GetInfo();
    }

}
