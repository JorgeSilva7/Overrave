using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewPlayer : MonoBehaviour {
	
	string[] sexos = {"MASCULINO","FEMENINO"};
	int currentSexo = 0;
	int currentTipo = 0;
	Sprite[] spriteSheetMen;
	Sprite[] spriteSheetWoman;
	int currentCharacterID;
	Image representation;
	InputField NombreInput;
	Text SexoTxt;
	Text TipoNum;
	Button SexoBtnDer;
	Button SexoBtnIzq;
	Button TipoBtnIzq;
	Button TipoBtnDer;
	Button BtnListo;

	Player Player;


	void Start () {
		NombreInput = GameObject.Find("NombreInput").GetComponent<InputField> ();

		SexoTxt = GameObject.Find("SexoTxt").GetComponent<Text> ();
		SexoTxt.text = sexos [currentSexo];
		SexoBtnDer = GameObject.Find("SexoBtnDer").GetComponent<Button> ();
		SexoBtnDer.onClick.AddListener (ClickBotonDerSexo);
		SexoBtnIzq = GameObject.Find("SexoBtnIzq").GetComponent<Button> ();
		SexoBtnIzq.onClick.AddListener (ClickBotonIzqSexo);

		TipoNum = GameObject.Find("TipoNum").GetComponent<Text> ();
		TipoNum.text = (currentTipo+1)+"";
		TipoBtnDer = GameObject.Find("TipoBtnDer").GetComponent<Button> ();
		TipoBtnDer.onClick.AddListener (ClickBotonDerTipo);
		TipoBtnIzq = GameObject.Find("TipoBtnIzq").GetComponent<Button> ();
		TipoBtnIzq.onClick.AddListener (ClickBotonIzqTipo);

		BtnListo = GameObject.Find("BtnListo").GetComponent<Button> ();
		BtnListo.interactable = false;
		BtnListo.onClick.AddListener (ClickBotonListo);

		representation = GameObject.Find ("Representation").GetComponent<Image> ();
		currentCharacterID = 0;
		spriteSheetMen = Resources.LoadAll<Sprite> ("Sprites/Characters/Men/MenCustomize");
		spriteSheetWoman = Resources.LoadAll<Sprite> ("Sprites/Characters/Woman/WomanCustomize");
	
		Player = GameObject.Find("Player").GetComponent <Player> ();
	
	}

	void Update(){
		if (NombreInput.text.Length > 4) {
			BtnListo.interactable = true;
		} else {
			BtnListo.interactable = false;
		}
	}

	void ClickBotonListo(){
		Player.setName (NombreInput.text);
		Player.setSexo (sexos[currentSexo]);
		Player.setTipo (currentTipo);
		Application.LoadLevel (2);
	}

	public void ClickBotonDerTipo(){
		if (currentTipo == 14) {
			currentTipo = 0;
		} else {
			currentTipo++;
		}
		TipoNum.text = (currentTipo+1)+"";
		cambiarPersonaje (currentTipo, currentSexo);

	}

	public void ClickBotonIzqTipo(){
		if (currentTipo == 0) {
			currentTipo = 14;
		} else {
			currentTipo--;
		}
		TipoNum.text = (currentTipo + 1) + "";
		cambiarPersonaje (currentTipo, currentSexo);
	}

	public void ClickBotonDerSexo(){
		if (currentSexo == 1) {
			currentSexo = 0;
		} else {
			currentSexo++;
		}
		SexoTxt.text = sexos [currentSexo];
		cambiarPersonaje (currentTipo, currentSexo);

	}

	public void ClickBotonIzqSexo(){
		if (currentSexo == 0) {
			currentSexo = 1;
		} else {
			currentSexo--;
		}
		SexoTxt.text = sexos [currentSexo];
		cambiarPersonaje (currentTipo, currentSexo);
	}

	public void cambiarPersonaje(int currentID, int currentSexo){
		if (currentSexo == 0) {
			foreach (Sprite S in spriteSheetMen) {
				if (S.name.Equals ("MenCustomize_" + currentID)) {
					representation.sprite = S;
				}
			}
		}else{
			foreach (Sprite S in spriteSheetWoman) {
				if (S.name.Equals ("WomanCustomize_" + currentID)) {
					representation.sprite = S;
				}
			}
		}
	}
}
