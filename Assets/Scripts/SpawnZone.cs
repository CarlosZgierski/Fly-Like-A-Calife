using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone : MonoBehaviour
{
    //publicas
    public int esperaWaves;
    public int esperaInicio;
    public int esperaInimigos;
    public GameObject tier1;

    public static int numWaves;
    public float numInim;

    //pivadas
    

	// Use this for initialization
	IEnumerator Start ()
    {
        Globais.NUM_INIMIGOS = numInim;
        Globais.ESPERA = esperaInimigos;
        Globais.ESPERA_WAVE = esperaWaves;
        Globais.ESPERA_INICIO = esperaInicio;

        yield return new WaitForSeconds(esperaInicio);
        while (Globais.PLAYER_VIVO == true)
        {
            Globais.NUM_INIMIGOS = numInim;
            Globais.ESPERA = esperaInimigos;
            Globais.ESPERA_WAVE = esperaWaves;
            Globais.ESPERA_INICIO = esperaInicio;

            for (int x = 0; x < numInim; x++)
            {
                Vector3 spawn = new Vector3(Random.Range(-3.136f, 3.151f), transform.position.y, 0f);
                Instantiate(tier1, spawn, Quaternion.identity);
                yield return new WaitForSeconds(esperaInimigos);
            }
            yield return new WaitForSeconds(esperaWaves);
            numInim += (5*GameController.fatorDif);
            Globais.WAVE ++;
        }
    }
}
