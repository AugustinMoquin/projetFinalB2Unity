using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ratsattaque : MonoBehaviour
{
    public int Healdamage;

    private bool _isPlayerInTrigger = false;
    private GameObject _player;

    private void Update()
    {
        if (_isPlayerInTrigger)
        {
            if (!Input.GetMouseButton(1))
            {
                Debug.Log("bouclier");
                _player.GetComponent<PlayerHpScript>().UpdateHp(-Healdamage);
            }
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _isPlayerInTrigger = true;
        _player = other.gameObject;



    }

    private void OnTriggerExit(Collider other)
    {

        _isPlayerInTrigger = false;

    }
}
