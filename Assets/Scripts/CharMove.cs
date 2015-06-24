using UnityEngine;
using System.Collections;

public class CharMove : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow))
		{

			Debug.Log ("penguin moves");
			transform.position += Vector3.forward * (Time.deltaTime) * 20;
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			
			Debug.Log ("penguin rotating");
			transform.rotation = Quaternion.AngleAxis  (30, Vector3.up);
		}
	}
}