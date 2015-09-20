using UnityEngine;
using System.Collections;

public class RobotController : MonoBehaviour {

	public Transform transform = null;

	public float movementSpeed = 5.0f;
	public float rotationSpeed = 1.0f;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A)) {
			transform.Rotate((Vector3.down) * rotationSpeed);
		} else if (Input.GetKey ("d")) {
			transform.Rotate((Vector3.up) * rotationSpeed);
		}

		if (Input.GetKey ("w")) {
			transform.position += transform.right * movementSpeed * Time.deltaTime;
		} else if (Input.GetKey ("s")) {
			transform.position -= transform.right * movementSpeed * Time.deltaTime;
		}
	}
}
