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
<<<<<<< HEAD
            Paused = false;
=======
            Paused = false; 
>>>>>>> 2759195f3cbcf21f85b4ec1f84cfbe87d9d7bdd8
        }
        void Update()
        {
            Pause();
        }

        void OnTriggerEnter2D(Collider2D other)
        {
            UI.SetActive(true);
<<<<<<< HEAD
            TextMesh text = UI.GetComponent<TextMesh>();
            text.text = transform.name;
=======
            Text text = UI.GetComponent<Text>();
            text.text =  transform.name;
>>>>>>> 2759195f3cbcf21f85b4ec1f84cfbe87d9d7bdd8
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