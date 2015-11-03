using UnityEngine;
using System.Collections;

public class CrearEscenario : MonoBehaviour {
	public GameObject Escenario;

	// Use this for initialization
	void Start () {
		Generar ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	public void Generar(){
		Instantiate (Escenario, transform.position, transform.rotation);
		InvokeRepeating ("Generar",42,42);
	}
}
