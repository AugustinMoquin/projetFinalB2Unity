using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordscript : MonoBehaviour
{
    public int Healdamage;


    private bool _isPlayerInTrigger = false;
    private GameObject _player;

    private void Update()
    {
        if (_isPlayerInTrigger)
        {
            _player.GetComponent<HpMonster>().UpdateHp(-Healdamage);
          
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        
            _isPlayerInTrigger = true;
            _player = other.gameObject;
            Debug.Log(other.gameObject);

    }

    private void OnTriggerExit(Collider other)
    {
        _isPlayerInTrigger = false;

    }
}
