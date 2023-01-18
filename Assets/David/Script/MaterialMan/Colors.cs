
using UnityEngine;

public class Colors : MonoBehaviour
{
    [SerializeField] public Material material;
    [SerializeField] bool ParteColore = true;
    [SerializeField] public Color[] colors;

    public void ModificaParte(bool PChang)
    {
        ParteColore = PChang;
    }

    public void ModificaColore(int Index)
    {

        if (ParteColore)
        {
            material.SetColor("_PrimaryColor", colors[Index]);
        }
        else
        {
            material.SetColor("_SecondaryColor", colors[Index]);
        }

    }

}
