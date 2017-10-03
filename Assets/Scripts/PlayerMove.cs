﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Viaje;

namespace Viaje
{
    public class PlayerMove : MonoBehaviour
    {

        
        // variables
        public Vector2 speed = new Vector2(50, 50);
        public bool puedeSaltar = false;
        public int salto;
        public bool giro = false;
        public bool gotCard = false;

        // reference
        public Rigidbody2D rb;
        public Animator ani;
        private Transform july;
        private Transform direction;



        // Use this for initialization
        void Start()
        {
            ani = GetComponent<Animator>();
            rb = GetComponent<Rigidbody2D>();
            july = this.transform.Find("JulioFull");
        }


        // Ground check
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "floor")
            {
                puedeSaltar = true;
                ani.SetBool("Saltar", false);
            }

            if(col.tag == "goldCard")
            {
                gotCard = true;
                Destroy(col.gameObject);
            }
        }

        private void OnTriggerStay2D(Collider2D col)
        {
            if (col.tag == "floor")
            {
                puedeSaltar = true;
                ani.SetBool("Saltar", false);
            }
        }

        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.tag == "floor")
            {
                puedeSaltar = false;
                ani.SetBool("Saltar", true);
            }
        }


        // Update is called once per frame
        void Update()
        {
            //-----Movement-----//
            float inputx = Input.GetAxisRaw("Horizontal");
            Vector3 movement = new Vector3(speed.x * inputx, 0, 0);
            movement *= Time.deltaTime;
            transform.Translate(movement);

            if (Input.GetKeyDown("right"))
            {
                ani.SetBool("Move", true);
                if (giro)
                {
                    july.Rotate(0, 180, 0);
                    giro = false;
                }
            }
            if (Input.GetKeyDown("left"))
            {
                ani.SetBool("Move", true);
                if (!giro)
                {
                    july.Rotate(0, 180, 0);
                    giro = true;
                }
            }

            if (Input.GetKeyUp("left") || Input.GetKeyUp("right"))
            {
                ani.SetBool("Move", false);
            }


            //-----Jump-----//
            if (puedeSaltar)
            {
                if (Input.GetKeyDown("space"))
                {
                    rb.AddForce(Vector2.up * salto);
                }
            }
        }


    }
    


}
