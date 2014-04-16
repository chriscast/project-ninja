using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CharacterController))]
public class jump : MonoBehaviour
{
	CharacterController _controller;
	float yPower = 0;
	float gravity = 9.8F;

	void Start()
	{
		_controller = GetComponent<CharacterController>();
	}
	// Update is called once per frame
	void FixedUpdate ()
	{
		yPower = yPower + (gravity * Time.deltaTime * -1F);
		Vector3 motion = new Vector3(0, yPower, 0);
		_controller.Move(motion);
	}
	void Update()
	{
		if(_controller.isGrounded)
		{
			if(Input.GetButtonDown("Jump"))
			{
				yPower = 0.6F;
			}
		}
	}
}
