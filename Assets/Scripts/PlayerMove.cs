using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {



    public Vector2 speed = new Vector2(50,50);
    public bool puedeSaltar = false;
    public int salto;
    
    public Rigidbody2D rb;
    public Animator ani;
    private Transform Pie;



	// Use this for initialization
	void Start () {
        
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        Pie = this.transform.Find("JulioPies");
    }
    
    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "floor")
        {
            puedeSaltar = true;
        }
    }

    private void OnTriggerStay2D(Collider2D col)
    {
        if (col.tag == "floor")
        {
            puedeSaltar = true;
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.tag == "floor")
        {
            puedeSaltar = false;
        }
    }
    

    // Update is called once per frame
    void Update () {
        //-----Movement-----//
        float inputx = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(speed.x * inputx, 0, 0);
        movement *= Time.deltaTime;
        transform.Translate(movement);

        if (Input.GetKeyDown("right"))
        {
            

        }
        if (Input.GetKeyDown("left"))
        {
            
        }

        if (Input.GetKeyUp("left") || Input.GetKeyUp("right"))
        {
            
        }


        //-----Jump-----//
        if (puedeSaltar)
        {
            if(Input.GetKeyDown("space"))
            {
                rb.AddForce(Vector2.up * salto);
            }
        }
            
            
            
        

    }






}
