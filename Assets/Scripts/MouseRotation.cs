using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseRotation : MonoBehaviour
{

    public float speed = 2.0f;

    private float yaw = 0.0f;
    private float pitch = 0.0f;
    private bool shouldCameraBeStopped = false;
    private Vector3 rotation = Vector3.zero;
    private Vector3 prevTouch;
    private bool isTouching;

    private void Update()
    {
        if(!shouldCameraBeStopped)
        {
            yaw += speed * Input.GetAxis("Mouse X");
            pitch -= speed * Input.GetAxis("Mouse Y");

            Vector3 rot = new Vector3(pitch, yaw, 0.0f);
            if (Application.platform == RuntimePlatform.Android && Input.GetTouch(0).phase == TouchPhase.Began)
            {
                prevTouch = rot;
            }

            Vector3 delta = rot - prevTouch;
            prevTouch = rot;

            rotation += delta;
            Debug.Log(rot);
            transform.eulerAngles = rotation;
        }
    }

    public void stopCamera()
    {
        shouldCameraBeStopped = true;
    }

    public void startCamera()
    {
        shouldCameraBeStopped = false;
    }
}