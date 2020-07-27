using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float movement_speed;
    public float movement_time;

    public Vector3 new_position;


    // Start is called before the first frame update
    void Start()
    {
        new_position = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        handle_movement_input();
    }

    void handle_movement_input()
    {
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            new_position += (transform.forward * movement_speed);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            new_position += (transform.forward * -movement_speed);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            new_position += (transform.right * movement_speed);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            new_position += (transform.right * -movement_speed);
        }

        transform.position = Vector3.Lerp(transform.position, new_position, Time.deltaTime * movement_time);
    }
}
