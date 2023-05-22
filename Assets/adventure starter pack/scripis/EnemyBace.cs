using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace littleDog
{

    public class EnemyBace : MovementBace,Iinteractable
    {
        public float lookRadius, AttackRadius;
        public Transform PlayerTarget;
        public bool isActive, isFocus;
        public string EnemyNameString;
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.red;        
            Gizmos.DrawWireSphere(transform.position, lookRadius);
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, AttackRadius);

        }


        public string GetAcationString()
        {
            return  "Attack "+EnemyNameString;
        }

        public float GetRadius()
        {
            return AttackRadius;
        }

        public void onDeFocus()
        {
            isFocus = false;

        }

        public void OnFocus(GameObject playerPos)
        {
            isFocus = true;
        }

        public void PlayAcation()
        {
           //do a thing
        }

        

        // Update is called once per frame
        void Update()
        {
            unitAni.SetFloat("speed", GetAgetSpeed());

            if (isActive == false)
            {
                if (_inRage(lookRadius) == true)
                {
                    isActive = true;
                    ChaseTarget(PlayerTarget);
                }
            }
         
        }

        bool _inRage(float R)
        {
            return Vector3.Distance(transform.position, PlayerTarget.position) <= R;
        }
    }

}
 

