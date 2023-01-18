using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SizeJacket : MonoBehaviour
{

    public void Size_Jacket(string Size)
    {
        string Name = PlayerPrefs.GetString("Nome");
        PlayerPrefs.SetString(Name+".Size",Size);
    }

}
