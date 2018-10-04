using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour {

    private Rigidbody rb;
    public float respawn;

    void Start ()
    {
        rb = GetComponent<Rigidbody>();
    }
	
	void Update ()
    {
        if(transform.position.y < respawn)
        {
            transform.position = new Vector3(0, 0, 0);
            rb.velocity = Vector2.zero;
        }
    }
}
