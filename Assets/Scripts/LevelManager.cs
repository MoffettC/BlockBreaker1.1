using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string name){
		Debug.Log("Level load requested for: " + name);
		Brick.brickCount=0;
		Application.LoadLevel(name);
	}
	
	public void Quit(){
		Debug.Log("Quit requested");
		Application.Quit();
	}

	public void LoadNextLevel(){
		Brick.brickCount=0;
		Application.LoadLevel(Application.loadedLevel + 1);
	}
	
	public void BrickDestroyed (){
		if (Brick.brickCount <= 0){
		LoadNextLevel();
		}
	}
}
