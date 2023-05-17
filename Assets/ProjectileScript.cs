using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{
    public float LifeTime;
    public GameObject FireFX;


    private void Start()
    {
        Destroy(gameObject, LifeTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);
        GameObject instaceFire = Instantiate(FireFX);
        instaceFire.transform.position = transform.position;

        Destroy(instaceFire, 3);

    }
}
