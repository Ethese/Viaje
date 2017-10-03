using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cheche
{
    public class Controller : MonoBehaviour
    {
        Rigidbody2D rb = new Rigidbody2D();
        public Animator anim;
        public GameObject GroundChecker;
        //public LayerMask ground;


        // Use this for initialization
        void Start()
        {
            rb = this.GetComponent<Rigidbody2D>();
            anim = GetComponent<Animator>();
        }

        // Update is called once per frame
        void Update()
        {
            movimiento();
            salto();
        }

        void FixedUpdate()
        {
            
        }

        void movimiento()
        {
            int velmov = 25;
            anim.SetFloat("ismoving", -1);
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                transform.Translate(Vector2.left * velmov * Time.deltaTime);
                anim.SetFloat("ismoving", 1);
            }

            if (Input.GetKey(KeyCode.RightArrow))
            {
                transform.Translate(Vector2.right * velmov * Time.deltaTime);
                anim.SetFloat("ismoving", 1);
            }
        }

        void salto()
        {
            int veljump = 500;
            //bool isGrounded = Physics2D.Linecast(transform.position, GroundChecker.transform.position, 1 << ground);
            if (Input.GetKeyDown(KeyCode.UpArrow) )
            {
                rb.AddForce(Vector2.up * veljump);
                Debug.Log("Salto");
            }

            Debug.DrawRay(transform.position, this.gameObject.transform.GetChild(0).transform.position, Color.green);
        }
    }
}
