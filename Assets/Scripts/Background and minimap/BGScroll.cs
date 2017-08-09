using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cheche
{
    public class BGScroll : MonoBehaviour
    {

        public Transform start;
        float scrollSpeed;
        public float tileSizeZ;
        GameObject ship;
        private Vector3 startPosition;

        void Start()
        {
            ship = GameObject.FindGameObjectWithTag("Player");
            
        }
        void Update()
        {
            Movimiento mov = ship.GetComponent<Movimiento>();
            

            startPosition = start.position;
            Movenemt();
            
            if (scrollSpeed > 0)
            {
                float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);

                mov.pos.x = 1;
                mov.pos.z = 0;
                mov.pos.y = -1;
                transform.position = startPosition - mov.pos * newPosition;
            }
            if (scrollSpeed == 0)
            {
                
            }
            
        }


        void Movenemt()
        {
            Movimiento mov = ship.GetComponent<Movimiento>();
            scrollSpeed = mov.maxSpeed;
        }
    }
}
