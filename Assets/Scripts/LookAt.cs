using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{
    public GameObject target;
    Vector3 cameraOffSet;

    // Use this for initialization
    void Start ()
    {
        //target = GameObject.Find("Sphere");
        //cameraOffSet = new Vector3(0, 3, -6);
	}
	
	// Update is called once per frame
	void LateUpdate ()
    {
        transform.position = target.transform.position + cameraOffSet;
    }
}
