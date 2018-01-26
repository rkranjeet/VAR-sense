using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonAction : MonoBehaviour {

	public void NextScene(string s)
	{
		SceneManager.LoadScene(s);
	}
}
