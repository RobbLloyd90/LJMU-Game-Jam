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
			// Move the object forward along its z axis 1 unit/second.
			transform.Translate(0, 0, 1);
		}
		if (Input.GetKeyDown(KeyCode.RightArrow))
		{
			
			Debug.Log ("penguin rotating");
			transform.localRotation *= Quaternion.AngleAxis (30, Vector3.up);
		}
	}
}