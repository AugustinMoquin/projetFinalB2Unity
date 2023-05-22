using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.AI;

namespace littleDog
{
    public class CameraControl : MonoBehaviour
    {
        public Transform target;
        public Vector3 offSet;
         public float pitch = 2f;
        public float ZoomSpeed = 4;
        public float[] minMaxZoom = new float[2] {5,15};
        public float currentZoom = 10f;
        private float currentYaw;
        private float yawSpeed = 100f;
        private void Update()
        {
            currentZoom -= Input.GetAxis("Mouse ScrollWheel") * ZoomSpeed;
            currentZoom = Mathf.Clamp(currentZoom, minMaxZoom[0], minMaxZoom[1]);
            currentYaw -= Input.GetAxis("Horizontal")*yawSpeed*Time.deltaTime;
           
        }
        private void LateUpdate()
        {
            transform.position = target.position - offSet * currentZoom;
            transform.LookAt(target.position + Vector3.up * pitch);
            transform.RotateAround(target.position, Vector3.up, currentYaw);
        }
    }
}
