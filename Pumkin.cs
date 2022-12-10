using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pumkin : MonoBehaviour
{
    public float moveForce = 10f;

    private Rigidbody myBody;

    void Awake()
    {
        myBody = GetComponent<Rigidbody>();
    }
    
    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < -11.5f)
        {
            Time.timeScale = 0f;
        }
    }

    void FixedUpdate()
    {
        MovePumkin();
    }

    void MovePumkin()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        myBody.AddForce(new Vector3(h * moveForce, 0f, v * moveForce));
    }

    void OnTriggerEnter(Collider target)
    {
        if (target.tag == "Golem" || target.tag == "Gates")
        {
            Time.timeScale = 0f;
        }
    }
}
