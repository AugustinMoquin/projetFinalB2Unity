using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float Speed;
    public float RotationSpeed;
    public float Jump; 
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float SpeedNonFrameDepend = Speed * Time.deltaTime;
        float SpeedNonFrameDependJump = Jump * Time.deltaTime;
        float RotationSpeedNonFrameDepent = RotationSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(new Vector3(0,RotationSpeedNonFrameDepent,0));
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(new Vector3(0, -RotationSpeedNonFrameDepent, 0));
        }


        if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.forward * SpeedNonFrameDepend);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().AddForce(transform.forward * -SpeedNonFrameDepend);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, Jump, 0));
        }
        float currentSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        GetComponent<Animator>().SetFloat("Speed",currentSpeed);
    }
}
