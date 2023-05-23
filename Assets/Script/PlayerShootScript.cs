using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShootScript : MonoBehaviour
{
    public GameObject Projectile;
    public float ProjectileSpeed;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GameObject instance = Instantiate(Projectile);
            instance.GetComponent<Transform>().position =
                this.gameObject.GetComponent<Transform>().position + new Vector3(0, 1, 0);
            instance.GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().forward * ProjectileSpeed);
        }
    }
}
