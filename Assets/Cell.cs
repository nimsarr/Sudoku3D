using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Cell : MonoBehaviour {

	TextMesh text;
	string latestKey;
	int i;
	int j;

	// Use this for initialization
	void Start () {
		text = GetComponentInChildren<TextMesh> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Alpha1))
			setKey ("1");
		else if (Input.GetKeyDown (KeyCode.Alpha2)) {
			setKey ("2");
		} else if (Input.GetKeyDown (KeyCode.Alpha3))
			setKey ("3");
		else if (Input.GetKeyDown (KeyCode.Alpha4))
			setKey ("4");
		else if (Input.GetKeyDown (KeyCode.Alpha5))
			setKey ("5");
		else if (Input.GetKeyDown (KeyCode.Alpha6))
			setKey ("6");
		else if (Input.GetKeyDown (KeyCode.Alpha7))
			setKey ("7");
		else if (Input.GetKeyDown (KeyCode.Alpha8))
			setKey ("8");
		else if (Input.GetKeyDown (KeyCode.Alpha9))
			setKey ("9");
		else if (Input.GetKeyDown (KeyCode.A))
			setKey ("A");
		else if (Input.GetKeyDown (KeyCode.B))
			setKey ("B");
		else if (Input.GetKeyDown (KeyCode.C))
			setKey ("C");
		else if (Input.GetKeyDown (KeyCode.D))
			setKey ("D");
		else if (Input.GetKeyDown (KeyCode.E))
			setKey ("E");
		else if (Input.GetKeyDown (KeyCode.F))
			setKey ("F");
		else if (Input.GetKeyDown (KeyCode.Alpha0))
			setKey ("0");
		else if (Input.GetKeyDown (KeyCode.Space))
			setKey (" ");

	}

	void OnMouseDown() {
		setNum (latestKey);
	}

	void setNum(string inNum){
		text.text = inNum;
	}

	void setKey(string key){
		latestKey = key;
	}
}
