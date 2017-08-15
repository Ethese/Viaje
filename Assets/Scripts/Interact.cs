using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interact : MonoBehaviour {

    //variable
    private bool doar = false;

    //reference
    public Canvas press;
    public Rigidbody2D ZaWarudo;
    
	// Use this for initialization
	void Start () {
        press = press.GetComponent<Canvas>();
        ZaWarudo = ZaWarudo.GetComponent<Rigidbody2D>();
        press.enabled = false;
        
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            press.enabled = true;
        }

        doar = true;

    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            press.enabled = true;
        }

        doar = true;

    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "Player")
        {
            press.enabled = false;
        }

        doar = false;
    }




    // Update is called once per frame
    void Update () {
        
	}
}
