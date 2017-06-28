using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {



    public Vector2 speed = new Vector2(50,50);
    private bool puedeSaltar = false;
    public int salto;

    public LayerMask LMk;
    public Rigidbody2D rb;
    public Animator ani;
    private Transform Pie;



	// Use this for initialization
	void Start () {
        
        ani = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
        Pie = this.transform.Find("JulioPies");
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
        puedeSaltar = Physics2D.Linecast(this.transform.position, Pie.position, LMk);
        if (puedeSaltar)
        {
            if (Input.GetKeyDown("space"))
            {
                rb.AddForce(Vector2.up * salto);
            }
        }

    }






}
