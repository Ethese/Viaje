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
            startPosition = start.position;
            Movenemt();
            float newPosition = Mathf.Repeat(Time.time * scrollSpeed, tileSizeZ);
           transform.position = startPosition + Vector3.left * newPosition;
        }


        void Movenemt()
        {
            Movimiento mov = ship.GetComponent<Movimiento>();
            scrollSpeed = mov.maxSpeed;
        }
    }
}
