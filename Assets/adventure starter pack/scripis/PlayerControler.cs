using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace littleDog
{
    public class PlayerControler : MovementBace
    {

         private Camera _CameraMain;
        public LayerMask interactiveLayerMask;
        public GameObject focus;
        public float GetAniSpeed()
        {
           bool isMoveinmg = GetAgetSpeed() > 0;
            return isMoveinmg ? 1 : 0;
        }
        public override void Start()
        {
            base.Start();
            _CameraMain = Camera.main;

        }
     
        // Update is called once per frame
        void Update()
        {

            unitAni.SetFloat("speed", GetAniSpeed());

            if (Input.GetMouseButtonDown(0))
            {

                if (Input.GetMouseButtonDown(0))
                {

                    RaycastHit hit;
                    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                    if (Physics.Raycast(ray, out hit, 100, interactiveLayerMask))
                    {

                        if (hit.transform.tag != "interactable")
                        {
                        SetTarget(hit.point);
                          _Setfocus(null);
                         ChaseTarget(null);
                        SetstoppingDistance(0);
                        }
                   

                    }
                }
            }
            if (Input.GetMouseButtonDown(1))
            {

                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit, 100, interactiveLayerMask))
                {
                    if (hit.transform.CompareTag("interactable"))
                    {
                        var I = hit.collider.GetComponent<Iinteractable>();
                        _Setfocus(hit.transform.gameObject);
                        I.OnFocus(this.gameObject);
                        SetstoppingDistance(I.GetRadius());
                        ChaseTarget(hit.transform);
                    }

                }
            }
        }

        private void _Setfocus(GameObject interactableBace)
        {
            if (focus != null) focus.GetComponent<Iinteractable>().onDeFocus(); 
            focus = interactableBace;
            
        }
    }
    
    
}
