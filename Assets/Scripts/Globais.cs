using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Globais : MonoBehaviour {

    public static bool PLAYER_VIVO;
    public static int VIDA_JOGADOR;
    public static int PONTUACAO;
    public static float NUM_INIMIGOS;
    public static int NUM_VIDAS_PLAYER;

    public static float ESPERA;
    public static float ESPERA_WAVE;
    public static float ESPERA_INICIO;

    public static int WAVE;

    // Use this for initialization
    void Start ()
    {
        WAVE = 1;
        PONTUACAO = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
		
	}
}
