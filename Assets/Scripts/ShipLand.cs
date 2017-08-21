using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cheche
{
    public class ShipLand : MonoBehaviour
    {
        public Animator anim;

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
            }

        }

    }
}
