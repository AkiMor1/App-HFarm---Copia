using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScreenScale : MonoBehaviour
{
    [SerializeField] CanvasScaler CanvasScaler;
    [SerializeField] Resolution LastResolution;

    private void Awake()
    {
        //Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeRight = false;
        SSize();
    }

    private void Update()
    {
        if (!Screen.currentResolution.Equals(LastResolution))
        {
            SSize();
        }
    }

    public void SSize()
    {
        CanvasScaler.referenceResolution = new Vector2 (Screen.currentResolution.width, Screen.currentResolution.height);
    }
}
