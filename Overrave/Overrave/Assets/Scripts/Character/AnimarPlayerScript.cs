using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimarPlayerScript : MonoBehaviour {

	public ArrayList spritesMen;
	public float framesPerSecond;
	private SpriteRenderer spriteRenderer;

	void Start () {
		spritesMen = new ArrayList ();
	}
	
	void Update () {
		int index = (int)(Time.timeSinceLevelLoad * framesPerSecond);
		//index = index % sprites.Length;
		//spriteRenderer.sprite = sprites[ index ];

	}

	void loadSpritesMen(){
		//spritesMen = Resources.LoadAll<Sprite> ("Sprites/Characters/Men/Sprite");
	}
}
