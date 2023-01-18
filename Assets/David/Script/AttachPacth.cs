using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;

public class AttachPacth : MonoBehaviour
{
    
    public GameObject[] patch;
    public bool OnAtpatch = true;
    [SerializeField]private Camera cam;
    [SerializeField] private GameObject target;

    private int IndexPacth;

    public void Update()
    {
        if (OnAtpatch)
        {
            Attach();
        }
    }

    private void Attach()
    {
        if (Input.touchCount == 1)
        {

            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {
                Debug.Log("inizio Rya");
                RaycastHit hit;
                Ray ray = cam.ScreenPointToRay(Input.GetTouch(0).position);
                Debug.Log("fine Rya");

                Debug.Log("inizio Ryap fisico ");
                Physics.Raycast(ray, out hit);

                Debug.Log("fine Rya fisisco");

                if (hit.collider == null)
                {
                    Debug.Log("hit colllider == null");
                    return;
                }
                else try
                {
                    if (hit.collider.gameObject.tag == target.tag)
                    {
                        GameObject clone = Instantiate(patch[IndexPacth], hit.collider.transform);
                        OnAtpatch = false;
                    }
                    else
                    {
                        Debug.Log("non ho trovato il tag giusto");
                    }
                }
                catch
                {
                    Debug.Log("Non sono riuscito a istanziare");
                    return;
                }
            }

        }
    }

    public void ClickPatch(int Index_Pacth)
    {
        IndexPacth = Index_Pacth;

        OnAtpatch = true;

    }
}
