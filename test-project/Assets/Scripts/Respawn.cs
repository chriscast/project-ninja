using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour
{
	public Transform _respawnPoint;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.localPosition.y < -10f)
		{
			transform.localPosition = _respawnPoint.position;
		}
	}
}
