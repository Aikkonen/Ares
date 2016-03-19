using UnityEngine;
using System.Collections;

public class AimMovement : MonoBehaviour {

	// Update is called once per frame
	void Update () 
	{

		//Mouse Position in the world. It's important to give it some distance from the camera. 
		//If the screen point is calculated right from the exact position of the camera, then it will
		//just return the exact same position as the camera, which is no good.
		Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);
		transform.LookAt(new Vector3(mouseWorldPosition.x, transform.position.y, mouseWorldPosition.z));
	}
	
}
