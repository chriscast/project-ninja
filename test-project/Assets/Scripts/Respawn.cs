using UnityEngine;
using System.Collections;

public class Respawn : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(transform.localPosition.y < -10f)
		{
			transform.localPosition = new Vector3(0f, 10f, 0f);
		}
	}
}
