using UnityEngine;
using System.Collections;

public class CubeRotation : MonoBehaviour {

	Vector3 point=new Vector3(1.5f,1.5f,1.5f);
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.UpArrow)) {
			print ("up");
			transform.RotateAround(point,Vector3.right,-45);
		}
		if (Input.GetKeyDown (KeyCode.DownArrow)) {
			print ("down");
			transform.RotateAround(point,Vector3.right,45);
		}
		if (Input.GetKeyDown(KeyCode.LeftArrow)) {
			print ("left");
			transform.RotateAround(point,Vector3.up,-45);

		}
		if (Input.GetKeyDown(KeyCode.RightArrow)) {
			print ("right");
			transform.RotateAround(point,Vector3.up,45);
		}
	}

}
