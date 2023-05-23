using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementMain : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public float vitesse = 5f;

    void Update()
    {
        float deplacementHorizontal = Input.GetAxis("Horizontal");
        float deplacementVertical = Input.GetAxis("Vertical");

        Vector3 deplacement = new Vector3(deplacementHorizontal, 0f, deplacementVertical) * vitesse * Time.deltaTime;
        transform.Translate(deplacement, Space.Self);
    }
}
