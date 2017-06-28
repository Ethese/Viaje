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
            
        }

        void FixedUpdate()
        {
            movimiento();
        }

        void rotacion()
        {
            Vector3 dir = this.transform.position;
            float angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
            this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        }

        void movimiento()
        {
            float rotationSpeed = 25;
            Vector2 velocity = Vector2.zero;
            float acceleration = 8000f;
            float maxVelocity = 20f;
            if (control)
            {
                float rotation = Input.GetAxis("Vertical") * rotationSpeed * Time.deltaTime;
                transform.Rotate(0, 0, rotation);

                Vector2 force = (Vector2)transform.right * Input.GetAxis("Horizontal") * acceleration * Time.deltaTime;
                velocity += force;
                velocity = Vector2.ClampMagnitude(velocity, maxVelocity);
                transform.Translate(velocity * Time.deltaTime);
            }
        }
    }
}
