using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHpScript : MonoBehaviour
{

    public int Maxhp;
    private int _currentHp;

    public GameObject CanvasHpImage;

    void Start()
    {
        _currentHp = Maxhp;
    }

    public void UpdateHp(int amount)
    {
        _currentHp += amount;
        if (_currentHp > Maxhp)
            _currentHp = Maxhp;

        if (_currentHp <= 0)
            Debug.Log("Death");

        CanvasHpImage.GetComponent<RectTransform>().localScale =
            new Vector3((float)_currentHp / (float)Maxhp, 1, 1);
    }
}