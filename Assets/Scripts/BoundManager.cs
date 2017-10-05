using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundManager : MonoBehaviour {
    private BoxCollider2D managerBox;
    public Transform player;
    public GameObject bound;

	// Use this for initialization
	void Start ()
    {
        managerBox = GetComponent<BoxCollider2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ManageBoundary();
    }

    void ManageBoundary()
    {
        if (managerBox.bounds.min.x < player.position.x && player.position.x < managerBox.bounds.max.x &&
            managerBox.bounds.min.y < player.position.y && player.position.y < managerBox.bounds.max.y)
        {
            bound.SetActive(true);
        }else
        {
            bound.SetActive(false);
        }
    }
}

