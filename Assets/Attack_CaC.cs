using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attack_CaC : MonoBehaviour

{
    public int Damage;
    public int FireRate;
    private float timer = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(GameManager.Instance.Player.transform);


        timer += Time.deltaTime;
        RaycastHit hit;
        Vector3 dir = GameManager.Instance.Player.transform.position - transform.position;

        if (Physics.Raycast(transform.position + new Vector3(0, 0.5f, 0), dir, out hit))
        {
            if (hit.transform.tag == "Player" && timer > FireRate)
            {
                GameManager.Instance.Player.GetComponent<PlayerHpScript>().UpdateHp(Damage);
                timer = 0;
            }
        }

    }
}
