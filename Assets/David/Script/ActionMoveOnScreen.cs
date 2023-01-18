using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class ActionMoveOnScreen : MonoBehaviour
{
    private bool UIIsTouch= false;
    private float RotateVelocity = 0.2f;
    [SerializeField]private LayerMask layerMask;

    [Header("Attiava Disattiva")]

    [Tooltip("Atiiva e disattiva il sistema di rotazzione del ogggetto selezionato")]
    [SerializeField] private bool Turn = true;

    [SerializeField]private GameObject Jacket;

    [SerializeField] private AttachPacth attachPacth;

    float InitialDistancePoint;
    Vector3 InitialScaleObj;

    public void Update()
    {
        if (attachPacth.OnAtpatch)
        {
            Debug.Log("sto bloccando");
        }
        else if (UIIsTouch)
        {

        }
        else if(Input.touchCount == 1)
        {
            Touch HitTouch = Input.GetTouch(0);
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);

            Physics.Raycast(ray, out hit);

            if(!Turn)
                return;
            try 
            {
                if (hit.collider.gameObject.layer == layerMask)
                    return;
            }
            catch
            {
                return;
            }


            if (Input.GetTouch(0).phase == TouchPhase.Began)
            {

            }
            else if(Input.GetTouch(0).phase == TouchPhase.Moved)
            {
                Turne(HitTouch);
            }
        }
       
    }

    public void UITouch(bool Touch)
    {
        UIIsTouch=Touch;
    }

    public void Turne(Touch HitTouch)
    {
        float Roation = -HitTouch.deltaPosition.x * RotateVelocity;
        Jacket.transform.rotation *= Quaternion.Euler(0, Roation, 0);
    }
}
