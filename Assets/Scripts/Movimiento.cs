using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cheche
{
    public class Movimiento : MonoBehaviour
    {
        Transform target;
        Rigidbody2D rb = new Rigidbody2D();
        bool control = true;
        // Use this for initialization
        void Start()
        {
            GameObject planeta = GameObject.FindGameObjectWithTag("Planets");
            rb = this.GetComponent<Rigidbody2D>();
            target = planeta.transform;
        }

        void Update()
        {
            movimiento();
        }

        void FixedUpdate()
        {
            rotacion();
        }

        void rotacion()
        {
            Vector3 dir = this.transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        void movimiento()
        {
            if (control)
            {
                //Caminar            
                if (Input.GetKey(KeyCode.RightArrow))
                {
                    rb.AddForce(Vector2.right * 300);
                }
                if (Input.GetKey(KeyCode.LeftArrow))
                {
                    rb.AddForce(Vector2.left * 300);
                }
                if (Input.GetKey(KeyCode.UpArrow))
                {
                    rb.AddForce(Vector2.up * 300);
                }
                if (Input.GetKey(KeyCode.DownArrow))
                {
                    rb.AddForce(Vector2.down * 300);
                }

                if (Input.GetKey(KeyCode.Space))
                {
                    rb.AddForce(Vector2.up * 800);
                }
            }
        }
    }
}
