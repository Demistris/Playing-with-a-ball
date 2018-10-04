using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Movements : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;
    public MouseRotation cameraControl;
    public Timer timerControl;
    public Texts displayWinText;
    public Texts displayCountText;

    void Start()
    {
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Vector3 tilt = new Vector3(Input.acceleration.x, 0.0f, -Input.acceleration.z);
        rb.AddForce(tilt * 5);
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("tree"))
        {
            other.gameObject.SetActive(false);
            rb.isKinematic = true;

            cameraControl.stopCamera();
            timerControl.stopTimer();
            displayWinText.winTextDisplay();

        }

        if (other.gameObject.CompareTag("coin"))
        {
            other.gameObject.SetActive(false);

            displayCountText.countTextDisplay();
        }
    }
}