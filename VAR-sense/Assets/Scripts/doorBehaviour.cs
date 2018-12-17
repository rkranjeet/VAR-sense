using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class doorBehaviour : MonoBehaviour {

	public Material[] materials;
	public Transform device;

	bool wasInFront;
	bool inOtherWorld;
	bool isColliding;

	// Use this for initialization
	void Start () {
		SetMaterial (false);
	}

	void SetMaterial(bool fullRender){
		var world = fullRender ? CompareFunction.NotEqual : CompareFunction.Equal;
		foreach (var material_i in materials) {
			material_i.SetInt ("_World", (int)world);
		}
	}
	bool GetIsInFront(){
		Vector3 worldPos = device.position + device.forward * Camera.main.nearClipPlane;
		Vector3 pos = transform.InverseTransformPoint (worldPos);
		return pos.z >= 0 ? true : false;
	}

	void OnTriggerEnter(Collider c){
		if(c.transform != device){
			return;
		}
		wasInFront = GetIsInFront ();
		isColliding = true;
	}

	void OnTriggerExit(Collider c){
		if(c.transform != device){
			return;
		}
		isColliding = false;
	}

	void WhileCameraColliding()
	{
		if (!isColliding)
			return;
		bool isInFront = GetIsInFront ();
		if((isInFront && !wasInFront) || (wasInFront && !isInFront)){
			inOtherWorld = !inOtherWorld;
			SetMaterial (inOtherWorld);
		}
		wasInFront = isInFront;
	}

	void Destroy(){
		SetMaterial (true);
	}

	// Update is called once per frame
	void Update () {
		WhileCameraColliding ();			
	}
}
