using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {
//Test GitHub
	public void LoadLevel(string name){
		Application.LoadLevel (name);
	}

	public void QuitRequest(){
		Application.Quit ();
	}
}
