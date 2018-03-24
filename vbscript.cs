using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbscript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject vButtonObject;
	// Use this for initialization
	void Start () {
		vButtonObject = GameObject.Find ("actionButton");
		vButtonObject.GetComponent<VirtualButtonBehaviour> ().RegisterEventHandler (this);
	}
	
	// Update is called once per frame
//	void Update () {
//		
//	}
	public void OnButtonPressed (VirtualButtonAbstractBehaviour vb){
		Debug.Log ("pressed");
	}

	public void OnButtonReleased (VirtualButtonAbstractBehaviour vb){
		
	}
}
