using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	string[,] Fb;
	string[,] Bb;
	string[,] Rb;
	string[,] Lb;
	string[,] Ub;
	string[,] Db;

	GameObject[,] Fg;
	GameObject[,] Bg;
	GameObject[,] Rg;
	GameObject[,] Lg;
	GameObject[,] Ug;
	GameObject[,] Dg;



	GameObject F;
	GameObject B;
	GameObject R;
	GameObject L;
	GameObject U;
	GameObject D;

	// Use this for initialization
	void Start () {
		Fg=new GameObject[4,4];
		Bg=new GameObject[4,4];
		Rg=new GameObject[4,4];
		Lg=new GameObject[4,4];
		Ug=new GameObject[4,4];
		Dg=new GameObject[4,4];
		createPuzzle ();
		createGameCube ();
	}
	
	// Update is called once per frame
	void Update () {
		updatePuzzle ();
		if (checkPuzzle ())
			Debug.Log ("solved!");
	}

	bool checkPuzzle(){
		for (int i=0; i<4; i++) {
			if(!checkGroup(getY (i))
				||!checkGroup(getX (i))
				||!checkGroup(getZ (i)))
				return false;
		}
		if (!checkGroup (getFace (Fb))
			|| !checkGroup (getFace (Bb))
			|| !checkGroup (getFace (Rb))
			|| !checkGroup (getFace (Lb))
			|| !checkGroup (getFace (Ub))
			|| !checkGroup (getFace (Db)))
			return false;

		return true;

	}

	//void displayComplete

	string[] getFace(string[,] face){
		string[] ret=new string[16];
		for (int i=0; i<4; i++) {
			for (int j=0; j<4; j++) {
				ret[4*i+j]=face[i,j];
			}
		}
		return ret;
	}

	string[] getY(int row){
		string[] ret=new string[16];
		for (int i=0; i<4; i++) {
			ret[i]=Fb[row,i];
		}
		for (int i=0; i<4; i++) {
			ret[4+i]=Rb[row,i];
		}
		for (int i=0; i<4; i++) {
			ret[8+i]=Bb[row,i];
		}
		for (int i=0; i<4; i++) {
			ret[12+i]=Lb[row,i];
		}
		return ret;
	}

	string[] getX(int row){
		string[] ret=new string[16];
		for (int i=0; i<4; i++) {
			ret[i]=Fb[i,row];
		}
		for (int i=0; i<4; i++) {
			ret[4+i]=Bb[i,row];
		}
		for (int i=0; i<4; i++) {
			ret[8+1]=Ub[row,i];
		}
		for (int i=0; i<4; i++) {
			ret[12+i]=Db[row,i];
		}
		return ret;
	}

	string[] getZ(int row){
		string[] ret=new string[16];
		for (int i=0; i<4; i++) {
			ret[i]=Fb[i,row];
		}
		for (int i=0; i<4; i++) {
			ret[4+i]=Bb[i,row];
		}
		for (int i=0; i<4; i++) {
			ret[8+i]=Rb[i,row];
		}
		for (int i=0; i<4; i++) {
			ret[12+i]=Lb[i,row];
		}
		return ret;
	}

	bool checkGroup(string[] group){
		bool[] bools;
		bool n0=false;
		bool n1=false;
		bool n2=false;
		bool n3=false;
		bool n4=false;
		bool n5=false;
		bool n6=false;
		bool n7=false;
		bool n8=false;
		bool n9=false;
		bool A=false;
		bool B=false;
		bool C=false;
		bool D=false;
		bool E=false;
		bool F=false;

		bools = new bool[16] {n0,n1,n2,n3,n4,n5,n6,n7,n8,n9,A,B,C,D,E,F};

		foreach (string s in group) {
			if (s.Equals("0") )
				n0=true;
			else if (s.Equals("1") ) {
				n1=true;
			} else if (s.Equals("2") )
				n2=true;
			else if (s.Equals("3"))
				n3=true;
			else if (s.Equals("4"))
				n4=true;
			else if (s.Equals("5") )
				n5=true;
			else if (s.Equals("6"))
				n6=true;
			else if (s.Equals("7"))
				n7=true;
			else if (s.Equals("8"))
				n8=true;
			else if (s.Equals("9"))
				n9=true;
			else if (s.Equals("A"))
				A=true;
			else if (s.Equals("B") )
				B=true;
			else if (s.Equals("C") )
				C=true;
			else if (s.Equals("D") )
				D=true;
			else if (s.Equals("E"))
				E=true;
			else if (s.Equals("F") )
				F=true;
		}

		foreach(bool b in bools){
			if(b==false)return false;
		}
		return true;
	}

	void updatePuzzle(){
		for (int i=0; i<4; i++) {
			for (int j=0; j<4; j++) {
				Fb[i,j]=Fg[i,j].GetComponentInChildren<TextMesh> ().text;
			}
		}
		for (int i=0; i<4; i++) {
			for (int j=0; j<4; j++) {
				Bb[i,j]=Bg[i,j].GetComponentInChildren<TextMesh> ().text;
			}
		}
		for (int i=0; i<4; i++) {
			for (int j=0; j<4; j++) {
				Rb[i,j]=Rg[i,j].GetComponentInChildren<TextMesh> ().text;
			}
		}
		for (int i=0; i<4; i++) {
			for (int j=0; j<4; j++) {
				Lb[i,j]=Lg[i,j].GetComponentInChildren<TextMesh> ().text;
			}
		}
		for (int i=0; i<4; i++) {
			for (int j=0; j<4; j++) {
				Ub[i,j]=Ug[i,j].GetComponentInChildren<TextMesh> ().text;
			}
		}
		for (int i=0; i<4; i++) {
			for (int j=0; j<4; j++) {
				Db[i,j]=Dg[i,j].GetComponentInChildren<TextMesh> ().text;
			}
		}
	}

	void createGameCube(){
		GameObject cell = Resources.Load ("Cell") as GameObject;
		F = GameObject.Find ("F");
		B = GameObject.Find ("B");
		R = GameObject.Find ("R");
		L = GameObject.Find ("L");
		U = GameObject.Find ("U");
		D = GameObject.Find ("D");

		
		//F
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cell) as GameObject;
				c.transform.position=new Vector3(j,i,-1);
				c.transform.Rotate(new Vector3(270,0,0));
				c.transform.SetParent(F.transform);
				c.GetComponent<Renderer> ().material.SetColor ("_Color", getCellColor(i));
				c.GetComponentInChildren<TextMesh> ().text=Fb[i,j];
				c.GetComponentInChildren<TextMesh> ().color=getFontColor(j);
				Fg[i,j]=c;
			}
		}
		
		//B
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cell) as GameObject;
				c.transform.position=new Vector3(j,i,4);
				c.transform.Rotate(new Vector3(270,180,0));
				c.transform.SetParent(B.transform);
				c.GetComponent<Renderer> ().material.SetColor ("_Color", getCellColor(i));
				c.GetComponentInChildren<TextMesh> ().text=Bb[i,j];
				c.GetComponentInChildren<TextMesh> ().color=getFontColor(j);
				Bg[i,j]=c;
			}
		}
		
		//R
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cell) as GameObject;
				c.transform.position=new Vector3(4,i,j);
				c.transform.Rotate(new Vector3(270,270,0));
				c.transform.SetParent(R.transform);
				c.GetComponent<Renderer> ().material.SetColor ("_Color", getCellColor(i));
				c.GetComponentInChildren<TextMesh> ().fontStyle=getFontStyle(j);
				c.GetComponentInChildren<TextMesh> ().text=Rb[i,j];
				Rg[i,j]=c;
			}
		}

		//L
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cell) as GameObject;
				c.transform.position=new Vector3(-1,i,j);
				c.transform.Rotate(new Vector3(270,90,0));
				c.transform.SetParent(L.transform);
				c.GetComponent<Renderer> ().material.SetColor ("_Color", getCellColor(i));
				c.GetComponentInChildren<TextMesh> ().fontStyle=getFontStyle(j);
				c.GetComponentInChildren<TextMesh> ().text=Lb[i,j];
				Lg[i,j]=c;
			}
		}
		
		//U
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cell) as GameObject;
				c.transform.position=new Vector3(i,4,j);
				c.transform.Rotate(new Vector3(0,0,0));
				c.transform.SetParent(U.transform);
				c.GetComponentInChildren<TextMesh> ().color=getFontColor(i);
				c.GetComponentInChildren<TextMesh> ().fontStyle=getFontStyle(j);
				c.GetComponentInChildren<TextMesh> ().text=Ub[i,j];
				Ug[i,j]=c;
			}
		}

		//D
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cell) as GameObject;
				c.transform.position=new Vector3(i,-1,j);
				c.transform.Rotate(new Vector3(0,180,180));
				c.transform.SetParent(D.transform);
				c.GetComponentInChildren<TextMesh> ().color=getFontColor(i);
				c.GetComponentInChildren<TextMesh> ().fontStyle=getFontStyle(j);
				c.GetComponentInChildren<TextMesh> ().text=Db[i,j];
				Dg[i,j]=c;
			}
		}
	}

	void createPuzzle(){
		Fb=new string[,]{ 
			{" ","D"," ","8"},
			{" "," ","A","1"},
			{"4"," "," "," "},
			{" ","6","C","7"}};
		Bb=new string[,]{ 
			{" "," ","0"," "},
			{" "," ","D"," "},
			{" "," "," ","3"},
			{" ","5"," ","B"}};
		Rb=new string[,]{ 
			{" "," ","6","7"},
			{" ","5"," "," "},
			{"8","D","A"," "},
			{" ","1"," ","4"}};
		Lb=new string[,]{ 
			{"1","3","5"," "},
			{"C","7"," ","2"},
			{"9","B","E"," "},
			{"0","F"," "," "}};
		Ub=new string[,]{ 
			{" ","6"," ","5"},
			{" ","E","1","C"},
			{" ","8"," ","B"},
			{" "," "," ","D"}};
		Db=new string[,]{ 
			{" "," ","F"," "},
			{" ","4"," ","3"},
			{" "," ","7","9"},
			{" ","A"," ","E"}};
	}

	Color getCellColor(int row){
		if (row == 0)
			return Color.blue;
		else if (row == 1)
			return Color.green;
		else if (row == 2)
			return Color.yellow;
		else if (row == 3)
			return Color.red;
		return Color.red;
	}

	Color getFontColor(int row){
		if (row == 0)
			return Color.magenta;
		else if (row == 1)
			return Color.gray;
		else if (row == 2)
			return new Color(0f,0.5f,0.75f);
		else if (row == 3)
			return new Color(1f,0.5f,0f);
		return Color.red;
	}

	FontStyle getFontStyle(int row){
		if (row == 0)
			return FontStyle.Normal;
		else if (row == 1)
			return FontStyle.Italic;
		else if (row == 2)
			return FontStyle.Bold;
		else if (row == 3)
			return FontStyle.BoldAndItalic;
		return FontStyle.Normal;
	}
}
