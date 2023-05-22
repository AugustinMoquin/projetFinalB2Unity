using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace littleDog
{
    public class InteractableBace : MonoBehaviour,Iinteractable
    {
        [SerializeField]
         float radius = 3f; 
        public bool isFocus;
        Transform _playerTransform;
        public string []  objectActionString = new string[1] { "insert Text" };
        bool _FoundTarget()
        {
            if (isFocus == false || _playerTransform == null) return false;
             return _getDistance() <= radius;
        }
        float _getDistance()
        {
            return Vector3.Distance(transform.position, _playerTransform.position) - 0.5f;
        }
        private void OnDrawGizmos()
        {
            Gizmos.color = Color.yellow;
            Gizmos.DrawWireSphere(transform.position, radius);
        }
       public float GetRadius()
        {
            return  radius;
        }
        public virtual void OnFocus(GameObject playerPos)
        {
             isFocus= true;
            _playerTransform= playerPos.transform;
            StartCoroutine(_FocusCoroutine());
        }
        public virtual void onDeFocus()
        {
            isFocus = false;
            _playerTransform = null;

        }
        public virtual void PlayAcation()
        {
            Debug.Log("finished");
        }
        IEnumerator _FocusCoroutine()
        {
            bool rechedGole = false;
            while(isFocus == true && rechedGole == false)             
            {
                if (_FoundTarget() == true) rechedGole = true;         
            yield return null;
            
            }
            if (rechedGole == true)
            {
                PlayAcation();
            }
        }

        public virtual string GetAcationString()
        {
            return objectActionString[0];
        }
    }
}
