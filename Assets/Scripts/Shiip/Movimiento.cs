using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
namespace Cheche
{
    public class Movimiento : MonoBehaviour
    {
        public float maxSpeed;
        public float rotSpeed = 180f;
        public bool isDown;
        public Animator anim;
        public Vector3 pos;
        public Quaternion rot;
        public GameObject planeta;
        void Start()
        {
            anim = GetComponent<Animator>();
        }

        void FixedUpdate()
        {
            shipMov();
        }
        void Update()
        {
            cambioscene();
        }

        void shipMov()
        {
            rot = transform.rotation;
            pos = transform.position;
            anim.SetBool("IsMoving", false);
            maxSpeed = 0;

            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                if (isDown == false)
                {
                    // ROTATE the ship.
                    // Grab our rotation quaternion
                    // Grab the Z euler angle
                    float z = rot.eulerAngles.z;
                    // Change the Z angle based on input
                    z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
                    // Recreate the quaternion
                    rot = Quaternion.Euler(0, 0, z);
                    // Feed the quaternion into our rotation
                    transform.rotation = rot;
                    // Finally, update our position!!
                    transform.position = pos;
                }
            }

            if (Input.GetAxisRaw("Horizontal") == 0)
            {
                isDown = false;
                rot = Quaternion.Euler(0, 0, 0);
            }

            if (Input.GetKey(KeyCode.Space))
            {
                maxSpeed = 5f;
                Vector3 velocity = new Vector3(maxSpeed * Time.deltaTime, 0, 0);

                pos += transform.rotation * velocity;

                transform.position = pos;
                anim.SetBool("IsMoving", true);
            }
        }

        void cambioscene()
        {
            //planeta = GameObject.FindGameObjectWithTag("Planets");
            Menu menu = planeta.GetComponent<Menu>();
            if (menu.activo == true)
            {
                Debug.Log(menu.nombre);
                if (Input.GetKeyDown(KeyCode.Y))
                {
                    SceneManager.LoadScene(menu.nombre);
                }
            }
        }
    }
}

