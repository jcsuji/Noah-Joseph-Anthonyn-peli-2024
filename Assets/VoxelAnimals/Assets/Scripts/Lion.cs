using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
public class Lion : MonoBehaviour
{
 
    public CharacterController controller;

    public int speed = 30;
 
    private float verticalSpeed = 0f;
    private float horizontalSpeed = 0f;
    private float mouseMovement = 0f;
 
    // Start is called before the first frame update
    void Start()
    {
 
    }
 
    // Update is called once per frame
    void Update()
    {
        verticalSpeed = Input.GetAxis("Vertical");
        horizontalSpeed = Input.GetAxis("Horizontal");
 
        Vector3 direction = new(horizontalSpeed, -1, verticalSpeed);

        // KÄÄNTYMINEN
        mouseMovement += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(0, mouseMovement, 0);
        direction = transform.rotation * direction;
 
        controller.Move(direction * Time.deltaTime * speed);
    }
}
