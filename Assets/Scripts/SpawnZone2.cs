using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnZone2 : MonoBehaviour {

    public GameObject tier2;

    private float numInimigos2;

	// Use this for initialization
	IEnumerator Start()
    {
        print(Globais.PLAYER_VIVO);

        while (Globais.PLAYER_VIVO == true)
        {
            yield return new WaitForSeconds(Globais.ESPERA_INICIO + 5);
            if (Globais.NUM_INIMIGOS >= 20)
            {
                numInimigos2 = (Globais.NUM_INIMIGOS -20) + 2;

                for (int x = 0; x < numInimigos2; x++)
                {
                    Vector3 spawn = new Vector3(Random.Range(-3.136f, 3.151f), transform.position.y, 0f);
                    Instantiate(tier2, spawn, Quaternion.identity);
                    yield return new WaitForSeconds(Globais.ESPERA + 5);
                }
                yield return new WaitForSeconds(Globais.ESPERA_WAVE);
            }
        }
    }
}
