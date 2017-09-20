using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public string name;
	public string sexo;
	public int tipo;

	void Start () {
		DontDestroyOnLoad (gameObject);
	}
	
	void Update () {
	}

	public void setName(string name){
		this.name = name;
	}
	public void setSexo(string sexo){
		this.sexo = sexo;
	}
	public void setTipo(int tipo){
		this.tipo = tipo;
	}

	public string getName(){
		return name;
	}
	public string getSexo(){
		return sexo;
	}
	public int getTipo(){
		return tipo;
	}
}
