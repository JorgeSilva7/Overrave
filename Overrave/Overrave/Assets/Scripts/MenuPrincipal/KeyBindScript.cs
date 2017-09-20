using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KeyBindScript : MonoBehaviour {
	
	private Dictionary<string,KeyCode> keys = new Dictionary<string, KeyCode> ();
	public Text arriba, abajo, derecha, izquierda,inventario,hab1,hab2,hab3,accion,atacar;
	private GameObject tecla;
	private Color32 normal = new Color32 (255,207,82,255);
	private Color32 select = new Color32 (239,116,36,255);

	void Start () {
		
		keys.Add ("ArribaButton", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("ArribaButton","W")));
		keys.Add ("AbajoButton", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("AbajoButton","S")));
		keys.Add ("DerechaButton", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("DerechaButton","D")));
		keys.Add ("IzquierdaButton", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("IzquierdaButton","A")));
		keys.Add ("InventarioButton", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("InventarioButton","I")));
		keys.Add ("Habilidad1Button", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("Habilidad1Button","Z")));
		keys.Add ("Habilidad2Button", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("Habilidad2Button","X")));
		keys.Add ("Habilidad3Button", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("Habilidad3Button","C")));
		keys.Add ("AccionButton", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("AccionButton","E")));
		keys.Add ("AtacarButton", (KeyCode)System.Enum.Parse(typeof(KeyCode),PlayerPrefs.GetString("AtacarButton","Q")));

		arriba.text = keys["ArribaButton"].ToString();
		abajo.text = keys["AbajoButton"].ToString();
		derecha.text = keys["DerechaButton"].ToString();
		izquierda.text = keys["IzquierdaButton"].ToString();
		inventario.text = keys["InventarioButton"].ToString();
		hab1.text = keys["Habilidad1Button"].ToString();
		hab2.text = keys["Habilidad2Button"].ToString();
		hab3.text = keys["Habilidad3Button"].ToString();
		accion.text = keys["AccionButton"].ToString();
		atacar.text = keys["AtacarButton"].ToString();


	}
	
	// Update is called once per frame
	void Update () {
		
		if (Input.GetKeyDown (keys ["ArribaButton"])) {
			Debug.Log ("ArribaButton");
		}
		if (Input.GetKeyDown (keys ["AbajoButton"])) {
			Debug.Log ("AbajoButton");
		}
		if (Input.GetKeyDown (keys ["DerechaButton"])) {
			Debug.Log ("DerechaButton");
		}
		if (Input.GetKeyDown (keys ["IzquierdaButton"])) {
			Debug.Log ("IzquierdaButton");
		}
		if (Input.GetKeyDown (keys ["Habilidad1Button"])) {
			Debug.Log ("Habilidad1Button");
		}
		if (Input.GetKeyDown (keys ["Habilidad2Button"])) {
			Debug.Log ("Habilidad2Button");
		}
		if (Input.GetKeyDown (keys ["Habilidad3Button"])) {
			Debug.Log ("Habilidad3Button");
		}
		if (Input.GetKeyDown (keys ["AccionButton"])) {
			Debug.Log ("AccionButton");
		}
		if (Input.GetKeyDown (keys ["InventarioButton"])) {
			Debug.Log ("InventarioButton");
		}
		if (Input.GetKeyDown (keys ["AtacarButton"])) {
			Debug.Log ("AtacarButton");
		}
	}

	void OnGUI(){
		if (tecla != null) {
			Event e = Event.current;
			if(e.isKey){
				keys [tecla.name] = e.keyCode;
				tecla.transform.GetChild(0).GetComponent<Text> ().text = e.keyCode.ToString ();
				tecla.GetComponent<Image>().color= normal;
				tecla = null;
			}
		}
	}

	public void CambiarTecla(GameObject clicked){
		if(tecla!=null){
			tecla.GetComponent<Image> ().color = normal;
		}

		tecla = clicked;
		tecla.GetComponent<Image> ().color = select;
	}

	public void GuardarTeclas(){
		foreach (var key in keys) {
			PlayerPrefs.SetString (key.Key, key.Value.ToString ());
		}

		PlayerPrefs.Save ();
	}
}
