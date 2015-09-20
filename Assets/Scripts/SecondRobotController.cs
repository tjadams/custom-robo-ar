using UnityEngine;
using System.Collections;

public class SecondRobotController : MonoBehaviour {
	
	public Transform transform = null;
	
	public float movementSpeed = 5.0f;
	public float rotationSpeed = 1.0f;
	
	void Start () {
		WebCamDevice[] devices = WebCamTexture.devices;
		for( var i = 0 ; i < devices.Length; i++ )
			Debug.Log(devices[i].name);
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.LeftArrow)) {
			transform.Rotate((Vector3.down) * rotationSpeed);
		} else if (Input.GetKey(KeyCode.RightArrow)) {
			transform.Rotate((Vector3.up) * rotationSpeed);
		}
		
		if (Input.GetKey (KeyCode.UpArrow)) {
			transform.position += transform.right * movementSpeed * Time.deltaTime;
		} else if (Input.GetKey (KeyCode.DownArrow)) {
			transform.position -= transform.right * movementSpeed * Time.deltaTime;
		}
	}
}
