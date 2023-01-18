using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class stop_animation : MonoBehaviour
{
    [SerializeField] Animator animator;
    [SerializeField] Button Button;

    public void Update()
    {
        AnimatorStateInfo Event = animator.GetCurrentAnimatorStateInfo(0);
        if (Event.IsName("Base Layer.Apparsi")|| Event.IsName("Base Layer.SiStannoChiudendo"))
        {
            print("ho iniziato");
            Button.enabled = false;
        }
        else
        {
            print("ho finito");
            Button.enabled = true;
        }
    }
}
