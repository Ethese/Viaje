using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Viaje;


namespace Viaje
{
    public class Interact : MonoBehaviour
    {

        //variable
        private bool moveOb = false;

        //reference
        public Canvas press;
        public Animator ZaWarudo;

        // Use this for initialization
        void Start()
        {
            press = press.GetComponent<Canvas>();
            ZaWarudo = ZaWarudo.GetComponent<Animator>();
            press.enabled = false;

        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                press.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ZaWarudo.SetBool("Open", true);
                }
            }
            

        }

        private void OnTriggerStay2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                press.enabled = true;
                if (Input.GetKeyDown(KeyCode.E))
                {
                    ZaWarudo.SetBool("Open", true);
                }
                
            }
            

        }

        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                press.enabled = false;
                ZaWarudo.SetBool("Open", false);
            }
            
        }




        // Update is called once per frame
        void Update()
        {

        }
    }
}
