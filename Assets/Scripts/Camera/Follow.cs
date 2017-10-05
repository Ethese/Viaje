using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Cheche
{
    public class Follow : MonoBehaviour
    {
        private BoxCollider2D cameraBox;
        public Transform Target;

        void Start()
        {
            cameraBox = GetComponent<BoxCollider2D>();
            Target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        }

        private void Update()
        {
            FollowPlayer();
            //AspectRatioBox();
        }

        void FollowPlayer()
        {
            if (GameObject.Find("Bound"))
            {
                transform.position = new Vector3
                    (Mathf.Clamp(Target.position.x, GameObject.Find("Bound").GetComponent<BoxCollider2D>().bounds.min.x + cameraBox.size.x /2 , GameObject.Find("Bound").GetComponent<BoxCollider2D>().bounds.max.x - cameraBox.size.x / 2),
                    Mathf.Clamp(Target.position.y, GameObject.Find("Bound").GetComponent<BoxCollider2D>().bounds.min.y + cameraBox.size.y /2 , GameObject.Find("Bound").GetComponent<BoxCollider2D>().bounds.max.y - cameraBox.size.y / 2),
                    transform.position.z);
            }
        }

        void AspectRatioBox()
        {
            //16:10
            if (Camera.main.aspect >= (1.6f) && Camera.main.aspect < (1.7f))
            {
                cameraBox.size = new Vector2(23, 14.3f);
            }
            //16:9
            if (Camera.main.aspect >= (1.7f) && Camera.main.aspect < (1.8f))
            {
                cameraBox.size = new Vector2(25.47f, 14.3f);
            }
            //5:4
            if (Camera.main.aspect >= (1.25f) && Camera.main.aspect < (1.3f))
            {
                cameraBox.size = new Vector2(18f, 14.3f);
            }
            //4:3
            if (Camera.main.aspect >= (1.3f) && Camera.main.aspect < (1.4f))
            {
                cameraBox.size = new Vector2(19.13f, 14.3f);
            }
            //3:2
            if (Camera.main.aspect >= (1.5f) && Camera.main.aspect < (1.6f))
            {
                cameraBox.size = new Vector2(21.6f, 14.3f);
            }
        }
    }
}
