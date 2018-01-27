using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class doorBehaviour : MonoBehaviour {

	public Material[] materials;

	// Use this for initialization
	void Start () {
		Debug.Log ("Game started");
		foreach (var material_i in materials) {
			material_i.SetInt ("_World", (int)CompareFunction.Equal);
		}
	}

	void OnTriggerStay(Collider c){
		if(c.name != "Main Camera"){
			return;
		}
		if (transform.position.z > c.transform.position.z) {
			foreach (var material_i in materials) {
				material_i.SetInt ("_World", (int)CompareFunction.Equal);
				Debug.Log ("World 1");
			}
		} else {
			foreach (var material_i in materials) {
				material_i.SetInt ("_World", (int)CompareFunction.NotEqual);
				Debug.Log ("World 2");
			}
		}
	}

	void Destroy(){
		Debug.Log ("Game ended");
		foreach (var material_i in materials) {
			material_i.SetInt ("_World", (int)CompareFunction.NotEqual);
		}
	}

	// Update is called once per frame
	void Update () {
		
	}
}
