using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Cheche
{
    public class Menu : MonoBehaviour
    {
        public GameObject UI;
        public bool activo;
        public string nombre;
        bool Paused;
        void Start()
        {
            Paused = false;
        }
        void Update()
        {
            Pause();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            activo = true;
            TextMesh text = UI.GetComponent<TextMesh>();
            nombre = transform.name;
            text.text = transform.name;
            UI.SetActive(true);
        }
        void OnTriggerExit2D(Collider2D other)
        {
            UI.SetActive(false);
            activo = false;
        }

        void Pause()
        {
            if (Input.GetKeyDown(KeyCode.Return))
            {
                Paused = !Paused;
            }
            if (Paused)
            {
                Time.timeScale = 0;
            }
            if (!Paused)
            {
                Time.timeScale = 1;
            }


        }

    }

}