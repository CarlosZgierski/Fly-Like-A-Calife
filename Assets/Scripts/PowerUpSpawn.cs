using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpSpawn : MonoBehaviour {

    public int tempoSpawn;
    public GameObject powerUp1;
    public GameObject powerUp2;
    public GameObject powerUpVida;
    public int primSpawn;


    private Vector3 spawn;
    private int qualPower;
    private GameObject qualSpawn;

    // Use this for initialization
    IEnumerator Start ()
    {
        yield return new WaitForSeconds(primSpawn);
        while (Globais.PLAYER_VIVO == true)
        {
            qualPower = (int)Random.Range(1, 6);
            if (qualPower == 1 || qualPower == 4)
                qualSpawn = powerUp1;
            if (qualPower == 2)
                qualSpawn = powerUp2;
            if (qualPower == 3 || qualPower == 5)
                qualSpawn = powerUpVida;


            spawn = new Vector3(Random.Range(-4.07f, 2.6f), Random.Range(-3.15f,3.151f), 0f);

            Instantiate(qualSpawn, spawn, Quaternion.identity);

            yield return new WaitForSeconds(tempoSpawn);

        }
    }
	
}
