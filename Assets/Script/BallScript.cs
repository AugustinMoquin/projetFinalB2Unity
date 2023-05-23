using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public Transform StartPos;
    public Transform EndPos;

    private float timer = 0;

    public AnimationCurve Curve;

    void Update()
    {
        timer += Time.deltaTime;

        /*
        transform.position = 
            Vector3.Lerp(
                StartPos.position, EndPos.position, Mathf.PingPong(timer,1));
        

        transform.position =
          Vector3.Lerp(
              StartPos.position, EndPos.position, (Mathf.Sin(timer)+1)/2);
        */

        transform.position =
            Vector3.Lerp(
                StartPos.position, EndPos.position, Curve.Evaluate(timer));
    }
}
