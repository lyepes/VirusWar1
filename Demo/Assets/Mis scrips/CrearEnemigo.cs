﻿using UnityEngine;
using System.Collections;

public class CrearEnemigo : MonoBehaviour {
    public GameObject[] Enemy;
    public GameObject[] Puntos;
	// Use this for initialization
	void Start () {
        InvokeRepeating("GenerarEnemy", 8, 8);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GenerarEnemy()
    {
        int ranEnemy = Random.Range(0, Enemy.Length);
        int ranPuntos = Random.Range(0, Puntos.Length);
        //int ranPuntos 
        Instantiate(Enemy[ranEnemy], Puntos[ranPuntos].transform.position,  Puntos[ranPuntos].transform.rotation);
    }



}
