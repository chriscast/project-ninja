using UnityEngine;
using System.Collections;

public class hitcheck : MonoBehaviour
{
	void OnTriggerEnter(Collider other)
	{
		Debug.Log("OnTriggerEnter with" + other);
	}
	
	void OnTriggerExit(Collider other)
	{
		Debug.Log("OnTriggerExit from" + other);
	}
	
	void OnCollisionEnter(Collision other)
	{
		Debug.Log("OnCollisionEnter with" + other);
	}
}
