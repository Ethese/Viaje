using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundCamera : MonoBehaviour {

    private BoxCollider2D cameraBox;
    private Transform player;
    public GameObject bound;

    // Use this for initialization
    void Start()
    {
        cameraBox = GetComponent<BoxCollider2D>();
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void AspectRatioBox()
    {
        //16:10
        if (Camera.main.aspect >= (1.6f) && Camera.main.aspect < (1.7f))
        {
            cameraBox.size = new Vector2(23f, 14.3f);
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
