using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swordscript : MonoBehaviour
{
    public int Healdamage;
    public GameObject HelpText;

    private bool _isPlayerInTrigger = false;
    private GameObject _player;

    private void Update()
    {
        if (_isPlayerInTrigger)
        {
            _player.GetComponent<HpMonster>().UpdateHp(-Healdamage);
            HelpText.SetActive(true);
            
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "changeling _novice") 
        { 
            _isPlayerInTrigger = true;
            _player = other.gameObject;
            Debug.Log("toucher");
            HelpText.SetActive(true);
        }

    }

    private void OnTriggerExit(Collider other)
    {

        _isPlayerInTrigger = false;
        HelpText.SetActive(false);
    }
}
