using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UAV_MovementController : MonoBehaviour
{
    public float speedOfMovement = 5f;
    public float speedOfRising = 5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.A))
        {
			transform.position = transform.position + (new Vector3(speedOfMovement, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
			transform.position = transform.position + (new Vector3(-speedOfMovement, 0, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
			transform.position = transform.position + (new Vector3(0, 0, speedOfMovement) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.W))
        {
			transform.position = transform.position + (new Vector3(0, 0, -speedOfMovement) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Q))
        {
			transform.position = transform.position + (new Vector3(0, speedOfRising, 0) * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.E))
        {
			transform.position = transform.position + (new Vector3(0, -speedOfRising, 0) * Time.deltaTime);
        }
    }
}
