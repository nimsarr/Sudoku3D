using UnityEngine;
using System.Collections;

public class Main : MonoBehaviour {

	// Use this for initialization
	void Start () {
		createGameCube ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void createGameCube(){
		GameObject cellF = Resources.Load ("CellF") as GameObject;
		GameObject cellB = Resources.Load ("CellB") as GameObject;
		GameObject cellR = Resources.Load ("CellR") as GameObject;
		GameObject cellL = Resources.Load ("CellL") as GameObject;
		GameObject cellU = Resources.Load ("CellU") as GameObject;
		GameObject cellD = Resources.Load ("CellD") as GameObject;
		
		//F
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cellF) as GameObject;
				c.transform.position=new Vector3(i,j,-1);
			}
		}
		
		//B
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cellB) as GameObject;
				c.transform.position=new Vector3(i,j,5);
			}
		}
		
		//R
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cellR) as GameObject;
				c.transform.position=new Vector3(4,i,j);
			}
		}

		//L
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cellL) as GameObject;
				c.transform.position=new Vector3(0,i,j);
			}
		}
		
		//U
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cellU) as GameObject;
				c.transform.position=new Vector3(i,4,j);
			}
		}

		//D
		for(int i=0;i<4;i++){
			for(int j=0;j<4;j++){
				GameObject c=Instantiate(cellD) as GameObject;
				c.transform.position=new Vector3(i,-1,j);
			}
		}
	}
}
