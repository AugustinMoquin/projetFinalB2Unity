using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class AttackheroeSword : MonoBehaviour
{

    public Animation anim;
    public int Healdamage;
    public GameObject HelpText;

    private bool _isPlayerInTrigger = false;
    private GameObject _player;

    // Start is called before the first frame update
    void Start()
    {
        
    }
     private bool click = false ;
     
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonUp(0)) {
            anim.GetComponent<Animator>().Play("Attackswordhero");

        }
        click = false;
            GetComponent<Animator>().SetBool("click", click);

    }
}
