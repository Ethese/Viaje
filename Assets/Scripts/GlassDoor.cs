using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Viaje;

namespace Viaje
{
    public class GlassDoor : MonoBehaviour
    {
        //reference
        public PlayerMove player;
        public Animator an;
        public Canvas end;

        // Use this for initialization
        void Start()
        {
            an = GetComponent<Animator>();
            end = end.GetComponent<Canvas>();
        }

        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                end.enabled = true;
            }
        }

        private void OnTriggerStay2D(Collider2D col)
        {

            if (col.tag == "Player")
            {
                end.enabled = true;
            }
        }

        private void OnTriggerExit2D(Collider2D col)
        {
            if (col.tag == "Player")
            {
                end.enabled = false;
            }
        }

        // Update is called once per frame
        void Update()
        {
            if (player.gotCard)
            {
                
                if (Input.GetKeyDown("e"))
                {
                    an.SetBool("openD",true);
                }
            }
        }
    }
}

