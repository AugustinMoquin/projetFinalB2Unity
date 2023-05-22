using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackheroeSword : MonoBehaviour
{

    public Animation anim;
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
