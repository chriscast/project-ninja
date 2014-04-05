using UnityEngine;
using System.Collections;

public class hitcheck : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("OnTriggerEnter with" + other);
	}

	void OnCollisionEnter(Collision other)
	{
		Debug.Log("OnCollisionEnter with" + other);
	}
}
