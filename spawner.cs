using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour {
	public GameObject zombie;
	Transform tr;
	// Use this for initialization
	void Start () {
		InvokeRepeating ("spawwnnerr",4f,10f);
		tr = GetComponent<Transform> ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void spawwnnerr(){
		Instantiate (zombie,tr.position,tr.rotation);



	}
}
