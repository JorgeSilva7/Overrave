using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuScript : MonoBehaviour {

	Button nuevaPartida;

	void Start () {
		nuevaPartida = GameObject.Find("Nueva Partida").GetComponent<Button> ();
		nuevaPartida.onClick.AddListener (clickBotonNuevaPartida);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void clickBotonNuevaPartida (){
		Application.LoadLevel (1);
	}
}
