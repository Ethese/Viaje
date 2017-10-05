using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cheche
{
    public class MovimientoJulio : MonoBehaviour
    {
        public float velmov;
        public bool control = false;
        float mov = 0;
        Rigidbody2D rb = new Rigidbody2D();
        public Animator anim;
        public Transform groundEnd;
        public GameObject nave;
        public LayerMask player;
        public bool volar;
        public GameObject UI;

        //LLANOS
        public bool puedeSaltar = false;
        public int salto;
        // Use this for initialization
        void Start()
        {
            rb = this.GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            takeControl();
            movimiento();
        }
        void FixedUpdate()
        {
            Salto();
        }

        void movimiento()
        {
            bool moving = false;
            mov = velmov;
            //Caminar            
            if (control == true)
            {
                if (Input.GetAxisRaw("Horizontal") > 0)
                {
                    transform.Translate(Vector2.right * mov * Time.deltaTime);
                    transform.localScale = new Vector3(-5, 5, 1);
                    moving = true;
                }

                if (Input.GetAxisRaw("Horizontal") < 0)
                {
                    transform.Translate(Vector2.left * mov * Time.deltaTime);
                    transform.localScale = new Vector3(5, 5, 1);
                    moving = true;
                }
            }
            anim.SetBool("Move", moving);
        }

        void takeControl()
        {
            ShipLand ship = nave.GetComponent<ShipLand>();
            if (ship.landed == true)
            {
                control = true;
            }
        }

        void OnTriggerStay2D(Collider2D coll)
        {
            if (coll.tag == "Piso" && coll.tag == "Muro")
            {
                UI.SetActive(true);
                TextMesh text = UI.GetComponent<TextMesh>();
                text.text = "Viajar?";
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    volar = true;
                }
            }
            else
            {
                Debug.Log("lawea");
                UI.SetActive(false);
            }

            //ptJump
            if (coll.tag == "floor" || coll.tag == "Piso")
            {
                puedeSaltar = true;
                anim.SetBool("Saltar", false);
            }
        }
        void OnTriggerExit2D(Collider2D coll)
        {
            UI.SetActive(false);

            //PtJump
            if (coll.tag == "floor" || coll.tag == "Piso")
            {
                puedeSaltar = false;
                anim.SetBool("Saltar", true);
                anim.SetBool("Move", false);
            }
        }


        //LLANOS
        // Ground check
        private void OnTriggerEnter2D(Collider2D col)
        {
            if (col.tag == "floor" || col.tag == "Piso")
            {
                puedeSaltar = true;
                anim.SetBool("Saltar", false);
            }
        }
        void Salto()
        {
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
