using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeMouseScript : MonoBehaviour
{


    private Vector3 MousePositionStart;
    private float MouseTimeStart;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            MousePositionStart = Input.mousePosition;
            MouseTimeStart = Time.time;
        }

        if (Input.GetMouseButtonUp(0))
        {
            float distance = Vector3.Distance(Input.mousePosition, MousePositionStart);
            float mouseTimeSpan = Time.time - MouseTimeStart;

            if (distance > 200 && mouseTimeSpan < 1.5f)
            {
                Debug.Log("Swipe");
                Vector2 Dir = Input.mousePosition - MousePositionStart;
            }
        }
    }
}
