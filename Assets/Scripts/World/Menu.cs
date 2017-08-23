using System.Collections;
using System.Collections.Generic;
<<<<<<< HEAD
//using UnityEngine.UI;
=======
>>>>>>> f4df945932c5e7fce6f3a6007ec15558af43631a
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
<<<<<<< HEAD
            Paused = false; 
=======
            Paused = false;
>>>>>>> f4df945932c5e7fce6f3a6007ec15558af43631a
        }
        void Update()
        {
            Pause();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
<<<<<<< HEAD
            UI.SetActive(true);
            TextMesh text = UI.GetComponent<TextMesh>();
            text.text = transform.name;
            activo = true;
=======
            activo = true;
            TextMesh text = UI.GetComponent<TextMesh>();
            text.text = transform.name;
            UI.SetActive(true);
>>>>>>> f4df945932c5e7fce6f3a6007ec15558af43631a
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