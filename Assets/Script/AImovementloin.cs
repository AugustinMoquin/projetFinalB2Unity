using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AImovementloin : MonoBehaviour
{
    public Transform Player;

    public float DistanceMinimale = 1f; // Distance minimale avant que le monstre ne commence à bouger

    private NavMeshAgent agent;
    private bool canMove = false;
    public GameObject Projectile;
    public float ProjectileSpeed;
    private float delayTimer = 2f; // Délai de 2 secondes
    private bool isDelayed = false;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 playerPosition = Player.position; // Position du joueur
        Vector3 monsterPosition = transform.position; // Position du monstre (supposant que ce script est attaché au monstre)

        float distance = Vector3.Distance(playerPosition, monsterPosition);

        if (distance <= 10f)
        {
            Debug.Log("oui");
            GetComponent<NavMeshAgent>().SetDestination(Player.position);
            if (!isDelayed)
            {
                delayTimer -= Time.deltaTime;

                if (delayTimer <= 0f)
                {
                    isDelayed = true;
                    Debug.Log("Délai terminé, effectuez l'action ici.");
                    // Effectuez l'action souhaitée après le délai
                        GameObject instance = Instantiate(Projectile);
                        instance.GetComponent<Transform>().position = this.gameObject.GetComponent<Transform>().position + new Vector3(0, 2, 0);
                        instance.GetComponent<Rigidbody>().AddForce(GetComponent<Transform>().forward * ProjectileSpeed);
                }
            }
        }

    }
}
