
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShrinkZone : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.gameObject.GetComponent<Transform>().localScale = new Vector3(0.5f, 0.5f, 0.5f);
    }

    private void OnTriggerExit(Collider other)
    {
        other.gameObject.GetComponent<Transform>().localScale = new Vector3(1f, 1f, 1f);
    }

    private void OnTriggerStay(Collider other)
    {

    }
}
