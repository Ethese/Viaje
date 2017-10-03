using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
namespace Cheche
{
    public class ShipLand : MonoBehaviour
    {
        public Animator anim;
        public bool landed = false;
        public GameObject Julio;
        void Start()
        {
            anim = GetComponent<Animator>();
            anim.enabled = true;
        }
        // Update is called once per frame
        void Update()
        {
            if (transform.position.y < 32)
            {
                anim.enabled = false;
                landed = true;
                Julio.SetActive(true);
            }
            MovimientoJulio mov = Julio.GetComponent<MovimientoJulio>();
            if (mov.volar == true)
            {
                Julio.SetActive(false);
                anim.Play("Landing1");
                anim.enabled = true;
                if (transform.position.y > 999)
                {
                    SceneManager.LoadScene("Space");
                }
            }
        }

    }
}
