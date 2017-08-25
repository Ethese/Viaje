using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
namespace Cheche
{
    public class Distance : MonoBehaviour
    {
        public GameObject player;
        Vector3 startPoint;
        // Use this for initialization
        void Start()
        {
            startPoint = transform.position;
        }

        // Update is called once per frame
        void Update()
        {
            Distancia();
            Rotacion();
        }

        void Distancia()
        {
            TextMesh text = gameObject.GetComponent<TextMesh>();
            float metersX = player.transform.position.x - startPoint.x;
            float metersY = player.transform.position.y - startPoint.y;
            int fixMeters = (int)(metersX + metersY);
            if (fixMeters < 0)
            {
                fixMeters = fixMeters * -1;
            }
            if (fixMeters <= 3)
            {
                text.text = " ";
            }
            {
                text.text = fixMeters.ToString();
            }
        }

        void Rotacion()
        {
            //Movimiento mov = player.GetComponent<Movimiento>();
            transform.rotation = player.transform.rotation;
        }
    }
}
