using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

namespace Cheche
{
    public class Menu : MonoBehaviour
    {
        public GameObject UI;
        public bool activo;
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
            UI.SetActive(true);
            Text text = UI.GetComponent<Text>();
            text.text =  transform.name;
            activo = true;
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