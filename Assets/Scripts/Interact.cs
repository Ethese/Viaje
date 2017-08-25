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

        

        

        private void OnTriggerStay2D(Collider2D col)
        {
            press.enabled = true;
            if (col.tag == "Player" && Input.GetKeyDown(KeyCode.E))
            {
               
                ZaWarudo.SetBool("Open", true);
            }


        }

        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                press.enabled = false;
            }
            
        }




        // Update is called once per frame
        void Update()
        {

        }
    }
}
