using UnityEngine;
using System.Collections;

[AddComponentMenu("Character/FPS Input Controller Ex")]
[RequireComponent(typeof(CharacterMotor))]
public class FPSInputControllerEx : MonoBehaviour
{
	private CharacterMotor _motor;

	// Use this for initialization
	void Start ()
	{
		_motor = GetComponent<CharacterMotor>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		// Get the input vector from kayboard or analog stick
		Vector3 directionVector = new Vector3(Input.GetAxis("Horizontal"),
		                                      0,
		                                      Input.GetAxis("Vertical"));

		if (directionVector != Vector3.zero)
		{
			// Get the length of the directon vector and then normalize it
			// Dividing by the length is cheaper than normalizing when we already have the length anyway
			float directionLength = directionVector.magnitude;
			directionVector = directionVector / directionLength;
			
			// Make sure the length is no bigger than 1
			directionLength = Mathf.Min(1, directionLength);
			
			// Make the input vector more sensitive towards the extremes and less sensitive in the middle
			// This makes it easier to control slow speeds when using analog sticks
			directionLength = directionLength * directionLength;
			
			// Multiply the normalized direction vector by the modified length
			directionVector = directionVector * directionLength;
		}
		
		// Apply the direction to the CharacterMotor
		_motor.inputMoveDirection = transform.rotation * directionVector;
		_motor.inputJump = Input.GetButton("Jump");
	}
}
