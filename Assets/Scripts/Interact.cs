using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Viaje;


namespace Viaje
{
    public class Interact : MonoBehaviour
    {

        //variable
        private bool puedeInt = false;

        //reference
        public Canvas press;
        public Animator door;
        public Animator lever;

        // Use this for initialization
        void Start()
        {
            press = press.GetComponent<Canvas>();
            door = door.GetComponent<Animator>();
            lever = lever.GetComponent<Animator>();
            press.enabled = false;
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                press.enabled = true;
                puedeInt = true;
            }
        }

        private void OnTriggerStay2D(Collider2D col)
        {
            
            if (col.tag == "Player")
            {
                press.enabled = true;
                puedeInt = true;
            }
        }

        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                press.enabled = false;
                puedeInt = false;
            }
        }


        // Update is called once per frame
        void Update()
        {
            if (puedeInt)
            {
                if(Input.GetKey("e"))
                {
                    door.SetBool("open/close", true);
                    lever.SetBool("ud",true);
                }
            }


            
        }
    }
}
