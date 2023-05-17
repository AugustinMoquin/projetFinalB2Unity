using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyShootScript : MonoBehaviour
{

    public GameObject PrefabBullet;
    public GameObject SpawnArrow;
    public float FireRate;
    private float timer = 0;

    void Start()
    {

    }

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
                GameObject Bullet = Instantiate(PrefabBullet);
                Bullet.transform.position = SpawnArrow.transform.position;
                Bullet.transform.LookAt(GameManager.Instance.Player.transform);
                timer = 0;
            }
        }

    }
}
