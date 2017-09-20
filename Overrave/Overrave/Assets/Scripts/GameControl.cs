using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class GameControl : MonoBehaviour {

	public static GameControl control;

	public float health;
	public float stamina;
	public float experiencie;

	public int level;
	public int strength;
	public int velocity;
	public int life;
	public int intelligence;

	private Texture2D texture;
	private bool keyCpress = false;

	void Start(){
		texture = (Texture2D)Resources.Load ("we");
	}

	void Awake () {
		if (control == null) {
			DontDestroyOnLoad (gameObject);
			control = this;
		} else if (control != this) {
			Destroy (gameObject);
		}
	}
		
	void Update(){
		if (Input.GetKeyDown(KeyCode.C)) {
			if (keyCpress == false) {
				keyCpress = true;
			} else {
				keyCpress = false;
			}
		}
	}

	void OnGUI(){
		if(Application.loadedLevel == 2){
			if (keyCpress == true) {
				GUI.Label (new Rect (10, 10, texture.height, texture.width), texture);
				GUI.Label (new Rect (120, 40, 100,100), ""+level);
			} else  {

			}
		}
	}
}
