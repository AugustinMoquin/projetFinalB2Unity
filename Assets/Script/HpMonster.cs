using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HpMonster : MonoBehaviour
{
    public float _currentHp;
    public float _maxHp;
    
    void Start()
    {
        _currentHp = _maxHp; 
    }

    public void UpdateHp(int amount)
    {
        _currentHp += amount;
        if (_currentHp > _maxHp)
        {
            _currentHp = _maxHp;
        }
        if (_currentHp <= 0)
        {
            Destroy(gameObject);
            Debug.Log("Death");
        }
    }
        // Update is called once per frame
        void Update()
    {
        
    }
}
