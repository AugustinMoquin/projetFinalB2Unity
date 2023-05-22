using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace littleDog
{
    [RequireComponent(typeof(NavMeshAgent))]
    public class MovementBace : MonoBehaviour
    {
        // you dont need to touch it so i hid it 
        private NavMeshAgent _agent;
        public Animator unitAni;
        private Transform _target;
        public float stopDistence = 1;
        // Start is called before the first frame update
        public virtual void Start()
        {
            _agent = GetComponent<NavMeshAgent>();
        }

        public virtual void SetTarget(Vector3 target)
        {
            _agent.SetDestination(target);

        }
        public virtual float GetAgetSpeed()
        {
            return _agent.velocity.magnitude;
        }
        public void SetstoppingDistance(float input)
        {
            _agent.stoppingDistance = input;

        }
        public virtual void ChaseTarget(Transform Target)
        {
            bool hasTarget = Target != null;
             StopAllCoroutines();
             if (hasTarget == false)
            {
                _agent.updateRotation = true;
                _target = null;
                return;
            }
            _agent.updateRotation = false;
            _target = Target.transform;
            StartCoroutine(ChaseCoroutine());
        }
        public virtual IEnumerator ChaseCoroutine()
        {
            bool _isOn = true;
            while (_isOn == true)
            {
                if (_target != null)
                {
                    _agent.SetDestination(_target.position);
                    faceTarget();
                }
                else _isOn = false;
          
             
                yield return null;
            }
            _agent.updateRotation = true;

        }
        public void faceTarget()
        {
            var dir = (_target.position-transform.position).normalized;
            var lookRot = Quaternion.LookRotation(new Vector3(dir.x,0,dir.z));
            transform.rotation = Quaternion.Slerp(transform.rotation, lookRot, Time.deltaTime * 5f);
        }
    }
}
   
 