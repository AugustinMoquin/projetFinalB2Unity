using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{

    public float Speed;
    public float RotationSpeed;
    public float JumpForce;

    private bool _canJump = false;

    void Update()
    {

        float SpeedNonFrameDependent = Speed * Time.deltaTime;
        float RotationSpeedNonFrameDependent = RotationSpeed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.Rotate(new Vector3(0, RotationSpeedNonFrameDependent, 0));
        if (Input.GetKey(KeyCode.Q))
            transform.Rotate(new Vector3(0, -RotationSpeedNonFrameDependent, 0));
        if (Input.GetKey(KeyCode.Z))
            this.GetComponent<Rigidbody>().AddForce(transform.forward * SpeedNonFrameDependent);
        if (Input.GetKey(KeyCode.S))
            this.GetComponent<Rigidbody>().AddForce(transform.forward * -SpeedNonFrameDependent);

        if (_canJump && Input.GetKeyDown(KeyCode.Space))
            this.GetComponent<Rigidbody>().AddForce(new Vector3(0, JumpForce, 0));

        float currentSpeed = GetComponent<Rigidbody>().velocity.magnitude;
        GetComponent<Animator>().SetFloat("Speed", currentSpeed);
    }

    private void OnTriggerEnter(Collider other)
    {
        _canJump = true;
    }

    private void OnTriggerExit(Collider other)
    {
        _canJump = false;
    }
}
