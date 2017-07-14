using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {



    public Vector2 speed = new Vector2(50,50);
    public bool puedeSaltar = false;
    public int salto;
    public Vector3 eulerAngleVelocity;

    public Rigidbody2D rb;
    public Animator ani;
    private Transform cuerpo;



	// Use this for initialization
	void Start () {
        
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        cuerpo = this.transform.Find("playerJulio");
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
            ani.SetBool("Move", true);
            transform.Rotate(0,180,0);
        }
        if (Input.GetKeyDown("left"))
        {
            ani.SetBool("Move", true);
        }

        if (Input.GetKeyUp("left") || Input.GetKeyUp("right"))
        {
            ani.SetBool("Move", false);
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
