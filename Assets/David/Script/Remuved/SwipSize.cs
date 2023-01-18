using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipSize : MonoBehaviour
{
    float InitialDistancePoint;
    Vector3 InitialScaleObj;
    public void ScaleModeSwip(GameObject selectObject)
    {
        Touch Point0 = Input.GetTouch(0);
        Touch Point1 = Input.GetTouch(1);

        if (Point0.phase == TouchPhase.Ended && Point1.phase == TouchPhase.Ended) return;

        if (Point0.phase == TouchPhase.Began && Point1.phase == TouchPhase.Began)
        {
            InitialDistancePoint = Vector2.Distance(Point0.position, Point1.position);
            InitialScaleObj = selectObject.transform.localScale;
        }
        else
        {
            var currentDistace = Vector2.Distance(Point0.position, Point1.position);

            if (Mathf.Approximately(InitialDistancePoint, 0))
            {
                return;
            }
            var factor = currentDistace / InitialDistancePoint;

            selectObject.transform.localScale = InitialScaleObj * factor;

        }
    }
}
