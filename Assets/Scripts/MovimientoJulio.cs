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
        public bool isGrounded = false;
        public LayerMask player;
        public float veljump;
        public bool volar;
        public GameObject UI;
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
            isGrounded = Physics2D.Linecast(this.transform.position, groundEnd.position, 1 << player);
            movimiento();
        }
        void FixedUpdate()
        {
            salto();
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
                    transform.localScale = new Vector3(-10, 10, 1);
                    moving = true;
                }

                if (Input.GetAxisRaw("Horizontal") < 0)
                {
                    transform.Translate(Vector2.left * mov * Time.deltaTime);
                    transform.localScale = new Vector3(10, 10, 1);
                    moving = true;
                }
            }
            anim.SetBool("Walking", moving);
        }

        void salto()
        {

            if (Input.GetKey(KeyCode.Space) && isGrounded && control == true)
            {
                rb.AddForce(Vector2.up * veljump);
            }
            anim.SetBool("Jumping", isGrounded);
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
            if (coll.tag != "Piso")
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
                UI.SetActive(false);
            }
        }
        void OnTriggerExit2D(Collider2D coll)
        {
            UI.SetActive(false);
        }
    }
}
