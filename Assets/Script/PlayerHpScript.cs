using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerHpScript : MonoBehaviour
{
    public int Maxhp;
    public int _currentHp;
    public GameObject CanvasHPImage; 
    void Start()
    {
        _currentHp = Maxhp; 
    }
    public void UpdateHp(int amount)
    {
        if (!Input.GetMouseButton(1))
        {
            _currentHp += amount;
        }
        if (_currentHp > Maxhp)
        {
            _currentHp = Maxhp;
        }
        if (_currentHp <= 0) 
        {
            Debug.Log("Death");
            Destroy(CanvasHPImage);
        }
        CanvasHPImage.GetComponent<RectTransform>().localScale = new Vector3(1 , (float)_currentHp / (float)Maxhp, 1 ); 
    }
}
