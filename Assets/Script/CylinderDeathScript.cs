using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderDeathScript : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Sphere")
            Destroy(this.gameObject);
    }

    private void OnCollisionExit(Collision collision)
    {

    }

    private void OnCollisionStay(Collision collision)
    {

    }
}
