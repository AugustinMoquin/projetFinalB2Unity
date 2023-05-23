using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionScript : MonoBehaviour
{
    public int HealAmount;
    public GameObject HelpText;

    private bool _isPlayerInTrigger = false;
    private GameObject _player;

    private void Update()
    {
        if (_isPlayerInTrigger && Input.GetKeyDown(KeyCode.E))
        {
            _player.GetComponent<PlayerHpScript>().UpdateHp(-HealAmount);
            HelpText.SetActive(false);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {

            _isPlayerInTrigger = true;
            _player = other.gameObject;
            HelpText.SetActive(true);

    }

    private void OnTriggerExit(Collider other)
    {

            _isPlayerInTrigger = false;
            HelpText.SetActive(false);
    }
}
