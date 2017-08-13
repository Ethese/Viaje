using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cheche
{
    public class Menu : MonoBehaviour
    {
        public GameObject UI;
        public bool activo;
        void Update()
        {
           // UI.SetActive(false);
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            UI.SetActive(true);
            activo = true;
        }
        void OnTriggerExit2D(Collider2D other)
        {
            UI.SetActive(false);
            activo = false;
        }

    }

}