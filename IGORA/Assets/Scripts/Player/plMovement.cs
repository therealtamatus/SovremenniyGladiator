using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plMovement : MonoBehaviour {

    private CharacterController _charContr;
    public float speed;
    public Joystick joystick;

	void Start ()
    {
        _charContr = GetComponent<CharacterController>();
	}
	
	void Update ()
    {
        PlayerMovement();
	}

    void PlayerMovement()
    {
        //float deltaX = Input.GetAxis("Horizontal") * speed;
        //float deltaY = Input.GetAxis("Vertical") * speed;
        float deltaX = joystick.Horizontal* speed;
        float deltaY = joystick.Vertical * speed;
        Vector3 movement = new Vector3(deltaX, deltaY, 0);
        movement = Vector3.ClampMagnitude(movement, speed);
        movement *= Time.deltaTime;
        movement = transform.TransformDirection(movement);
        _charContr.Move(movement);
    }
}
