using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class Splash : MonoBehaviour {


	public Image splash;
	public string scene;

	IEnumerator Start(){
		splash.canvasRenderer.SetAlpha (0.0f);
		splash.CrossFadeAlpha (1.0f,1.5f,false);
		yield return new WaitForSeconds (2.0f);
		splash.CrossFadeAlpha (0.0f,1.5f,false);
		yield return new WaitForSeconds (2.0f);
		EditorSceneManager.LoadScene ("menu");
	}
}
