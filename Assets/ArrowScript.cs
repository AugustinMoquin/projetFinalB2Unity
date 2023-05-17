using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowScript : MonoBehaviour
{

    public float Speed;
    public float LifeTime;
    public int Damage;
    public GameObject FxCollision;

    void Start()
    {
        Destroy(gameObject, LifeTime);
    }

    void Update()
    {
        GetComponent<Rigidbody>().velocity = transform.forward * Speed;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            other.gameObject.GetComponent<PlayerHpScript>().UpdateHp(Damage);
        }

        GameObject Fx = Instantiate(FxCollision);
        Fx.transform.position = this.transform.position;
        Destroy(Fx, 2);
        Destroy(gameObject);
    }
}
