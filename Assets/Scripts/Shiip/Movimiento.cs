using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cheche
{
    public class Movimiento : MonoBehaviour
    {
        public float maxSpeed = 5f;
        public float rotSpeed = 180f;

        float shipBoundaryRadius = 0.5f;

        void Start()
        {

        }

        void FixedUpdate()
        {
            shipMov();
        }

        void shipMov()
        {
            // ROTATE the ship.
            // Grab our rotation quaternion
            Quaternion rot = transform.rotation;
            // Grab the Z euler angle
            float z = rot.eulerAngles.z;
            // Change the Z angle based on input
            z -= Input.GetAxis("Horizontal") * rotSpeed * Time.deltaTime;
            // Recreate the quaternion
            rot = Quaternion.Euler(0, 0, z);
            // Feed the quaternion into our rotation
            transform.rotation = rot;
            // Finally, update our position!!
            Vector3 pos = transform.position;
            transform.position = pos;
            if (Input.GetKey(KeyCode.Space))
            {
                Vector3 velocity = new Vector3(maxSpeed * Time.deltaTime, 0, 0);

                pos += transform.rotation * velocity;

                transform.position = pos;
            }
        }
    }
}

