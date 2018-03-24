using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbscript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vButtonObject;
	// Use this for initialization

	private GameObject goblin;

	void Start () {
		vButtonObject = GameObject.Find ("actionButton");
		goblin = GameObject.Find ("goblin");

//		vButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}
	
	// Update is called once per frame
//	void Update () {
//		
//	}
	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
		Debug.Log ("pressed");
		goblin.GetComponent<Animation> ().Play ();
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb){
		goblin.GetComponent<Animation> ().Stop ();
	}
}
